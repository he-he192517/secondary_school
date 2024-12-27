using System.Text;
using Furion.RemoteRequest.Extensions;
using FurSystemTest.Application.Filters;
using FurSystemTest.Application.Util;
using FurSystemTest.Core.Dtos;

namespace FurSystemTest.Application.Services
{
    public class AccountService : IAccountService, IDynamicApiController, ITransient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Cachelper _cachelper;
        public AccountService(IHttpClientFactory httpClientFactory, Cachelper cachelper)
        {
            _httpClientFactory = httpClientFactory;
            _cachelper = cachelper;
        }

        /// <summary>
        /// 获取用户信息，接口需要进行权限校验
        /// </summary>
        /// <returns></returns>
        [MyAuthorize]
        public ResponseModel<UserDto> GetUserInfo()
        {
            var user = new ResponseModel<UserDto>();
            return user;
        }

        /// <summary>
        /// 根据authCode获取token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResponseModel<GetTokenDto>> GetAccessCode([FromBody] GetAccessCodeRequest request)
        {
            //请求SSO获取 token
            var param = new { authCode = request.AuthCode };
            var jsonData = System.Text.Json.JsonSerializer.Serialize(param);

            // furion的httpClient工具进行post请求
            var response = await "https://www.sso.com:7137/api/sso/token"
                .SetBody(jsonData)
                .SetContentType("application/json")
                .PostAsAsync<ResponseModel<ResponseModel<GetTokenDto>>>();
            
            // 检查响应代码
            if (response.Code == ResponseCode.Success) return response.Data; // 成功

            //成功,缓存token到局部会话
            var token = response.Data.Data.Token;
            var Expires = response.Data.Data.Expires;
            var key = $"SessionCode:{request.SessionCode}";
            var tokenKey = $"token:{token}";
            _cachelper.StringSet(key, token, TimeSpan.FromSeconds(Expires));
            _cachelper.StringSet(tokenKey, true, TimeSpan.FromSeconds(Expires));
            Console.WriteLine($"获取token成功，局部会话code:{request.SessionCode},{Environment.NewLine}token:{token}");

            return response.Data;
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel LogOut([FromBody] LogOutRequest request)
        {
            var key = $"SessionCode:{request.sessionCode}";
            //根据会话取出token
            var token = _cachelper.StringGet<string>(key);
            if (!string.IsNullOrEmpty(token))
            {
                //清除token
                var tokenKey = $"token:{token}";
                _cachelper.DeleteKey(tokenKey);
            }
            Console.WriteLine($"会话Code:{request.sessionCode}退出登录");
            return new ResponseModel().SetSuccess();
        }
    }
}
