using FurSystemTest.Core.Dtos;

namespace FurSystemTest.Application.RBAC
{
    /// <summary>
    /// JWT服务接口
    /// </summary>
    public interface IJwtService
    {
        /// <summary>
        /// 获取授权码
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<ResponseModel<string>> GetCodeAsync(string clientId, string userName, string password);

        /// <summary>
        /// 根据会话Code获取授权码
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="sessionCode"></param>
        /// <returns></returns>
        ResponseModel<string> GetCodeBySessionCode(string clientId, string sessionCode);

        /// <summary>
        /// 获取Token+RefreshToken
        /// </summary>
        /// <param name="authCode"></param>
        /// <returns>Token+RefreshToken</returns>
        ResponseModel<GetTokenDto> GetTokenWithRefresh(string authCode);

        /// <summary>
        /// 基于refreshToken获取Token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        string GetTokenByRefresh(string refreshToken, string clientId);
    }
}
