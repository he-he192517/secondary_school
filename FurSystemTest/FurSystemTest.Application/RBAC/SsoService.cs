using System.Text;
using FurSystemTest.Application.Util;
using FurSystemTest.Core.Dtos;

namespace FurSystemTest.Application.RBAC
{
    /// <summary>
    /// 登录页面
    /// </summary>
    public class SsoService : ISsoService, IDynamicApiController, ITransient
    {
        private readonly IJwtService _jwtService;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly Cachelper _cachelper;

        public SsoService(IJwtService jwtService, IHttpClientFactory httpClientFactory, Cachelper cachelper)
        {
            _jwtService = jwtService;
            _httpClientFactory = httpClientFactory;
            _cachelper = cachelper;
        }

        ///// <summary>
        ///// 登录页面
        ///// </summary>
        ///// <returns></returns>
        //public IActionResult Login()
        //{
        //    return View();
        //}

        /// <summary>
        /// 获取授权码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseModel<string>> GetCodeAsync([FromBody] GetCoderRequest request)
        {
            var result = await _jwtService.GetCodeAsync(request.ClientId, request.UserName, request.PassWord);

            return result;
        }

        /// <summary>
        /// 根据授权码,获取Token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public ResponseModel<GetTokenDto> GetToken([FromBody] GetTokenRequestDTO request)
        {
            var result = _jwtService.GetTokenWithRefresh(request.authCode);
            return result;
        }

        /// <summary>
        /// 根据会话code获取授权码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel<string> GetCodeBySessionCode([FromBody] GetCodeBySessionCodeRequest request)
        {
            var result = _jwtService.GetCodeBySessionCode(request.ClientId, request.SessionCode);
            return result;
        }

        ///// <summary>
        ///// 退出登录页面
        ///// </summary>
        ///// <returns></returns>
        //public IActionResult LogOut()
        //{
        //    return View();
        //}

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<ResponseModel> LogOutApp([FromBody] LogOutRequest request)
        {
            //删除全局会话
            var sessionKey = $"SessionCode:{request.sessionCode}";
            _cachelper.DeleteKey(sessionKey);
            var client = _httpClientFactory.CreateClient();
            var param = new { sessionCode = request.sessionCode };
            var jsonData = System.Text.Json.JsonSerializer.Serialize(param);
            var paramContent = new StringContent(jsonData);

            //这里实战中是用数据库或缓存取
            var urls = new List<string>()
            {
                "https://localhost:7001/Account/LogOut",
                "https://localhost:7002/Account/LogOut"
            };
            //这里可以异步mq处理，不阻塞返回
            foreach (var url in urls)
            {
                //web1退出登录
                var logOutResponse = await client.PostAsync(url, new StringContent(jsonData, Encoding.UTF8, "application/json"));
                var resultStr = await logOutResponse.Content.ReadAsStringAsync();
                var response = System.Text.Json.JsonSerializer.Deserialize<ResponseModel>(resultStr);
                Console.WriteLine(response.Code == 0 //成功
                    ? $"url:{url},会话Id:{request.sessionCode},退出登录成功"
                    : $"url:{url},会话Id:{request.sessionCode},退出登录失败");
            };
            return new ResponseModel().SetSuccess();

        }
    }
}
