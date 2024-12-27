using FurSystemTest.Application.Filters;
using FurSystemTest.Core.Dtos;

namespace FurSystemTest.Application.Services
{
    public interface IAccountService
    {
        /// <summary>
        /// 获取用户信息，接口需要进行权限校验
        /// </summary>
        /// <returns></returns>
        [MyAuthorize]
        public ResponseModel<UserDto> GetUserInfo();

        /// <summary>
        /// 根据authCode获取token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ResponseModel<GetTokenDto>> GetAccessCode([FromBody] GetAccessCodeRequest request);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel LogOut([FromBody] LogOutRequest request);
    }
}
