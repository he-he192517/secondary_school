using FurSystemTest.Application.Util;
using FurSystemTest.Core.Dtos;
using FurSystemTest.Core.Repository;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.RBAC
{
    public class JwtRsService : JwtBaseService,IDynamicApiController, ITransient
    {
        public JwtRsService(IOptions<AppSettingOptions> options, Cachelper cachelper, IApplicationService applicationService, IUserReponsitory userReponsitory, IRoleReponsitory roleReponsitory) : base(options, cachelper, applicationService, userReponsitory, roleReponsitory)
        {

        }
        /// <summary>
        /// 生成非对称加密签名凭证
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        protected override SigningCredentials GetCreds(string clientId)
        {
            var appRsSetting = GetAppInfoByAppKey(clientId);
            var rsa = RSA.Create();
            var privateKey = Convert.FromBase64String(appRsSetting.privateKey);//这里只需要私钥，不要begin,不要end
            rsa.ImportPkcs8PrivateKey(privateKey, out _);
            var key = new RsaSecurityKey(rsa);
            var creds = new SigningCredentials(key, SecurityAlgorithms.RsaSha256);
            return creds;
        }
        /// <summary>
        /// 根据appKey获取应用信息
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        private AppRSSetting GetAppInfoByAppKey(string clientId)
        {
            var appRsSetting = AppSettingOptions.Value.appRSSettings.FirstOrDefault(s => s.clientId == clientId);
            return appRsSetting;
        }
    }
}
