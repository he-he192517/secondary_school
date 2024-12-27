using FurSystemTest.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.RBAC
{
    public interface ISsoService
    {
        /// <summary>
        /// 获取授权码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Task<ResponseModel<string>> GetCodeAsync([FromBody] GetCoderRequest request);

        /// <summary>
        /// 根据授权码,获取Token
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel<GetTokenDto> GetToken([FromBody] GetTokenRequestDTO request);


        /// <summary>
        /// 根据会话code获取授权码
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public ResponseModel<string> GetCodeBySessionCode([FromBody] GetCodeBySessionCodeRequest request);

        /// <summary>
        /// 退出登录
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// 
        public Task<ResponseModel> LogOutApp([FromBody] LogOutRequest request);
    }
}
