using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using FurSystemTest.Application.Util;
using FurSystemTest.Core.Dtos;
using FurSystemTest.Core.Repository;


namespace FurSystemTest.Application.RBAC
{
    /// <summary>
    /// jwt服务
    /// </summary>
    public abstract class JwtBaseService : IJwtService
    {
        protected readonly IOptions<AppSettingOptions> AppSettingOptions;
        protected readonly Cachelper Cachelper;
        protected readonly IApplicationService ApplicationService;
        protected readonly IUserReponsitory UserReponsitory;
        protected readonly IRoleReponsitory RoleReponsitory;

        protected JwtBaseService(IOptions<AppSettingOptions> appSettingOptions, Cachelper cachelper, IApplicationService applicationService, IUserReponsitory userReponsitory, IRoleReponsitory roleReponsitory)
        {
            AppSettingOptions = appSettingOptions;
            Cachelper = cachelper;
            ApplicationService = applicationService;
            UserReponsitory = userReponsitory;
            RoleReponsitory = roleReponsitory;
        }

        /// <summary>
        /// 获取授权码
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<ResponseModel<string>> GetCodeAsync(string clientId, string userName, string password)
        {
            var result = new ResponseModel<string>();
            var appHsSetting = ApplicationService.GetApplication(clientId);
            //var appHsSetting = AppSettingOptions.Value.appHSSettings.FirstOrDefault(s => s.clientId == clientId);
            if (appHsSetting == null)
            {
                result.SetFail("应用不存在");
                return result;
            }

            if (!UserReponsitory.CheckUser(userName, password))
            {
                result.SetFail("用户名或密码不正确");
                return result;
            }

            //用户信息
            var userDetail = UserReponsitory.GetUser(userName);
            var currentUserModel = new CurrentUserModel
            {
                Id = userDetail.UserId,
                Account = userName,
                Name = userDetail.UserName,
                Mobile = userDetail.Mobile,
                Role = RoleReponsitory.GetRoleByUserName(userName, clientId)
            };

            //生成授权码
            var code = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            var key = $"AuthCode:{code}";
            var appCachekey = $"AuthCodeClientId:{code}";
            //缓存授权码
            Cachelper.StringSet<CurrentUserModel>(key, currentUserModel, TimeSpan.FromMinutes(10));
            //缓存授权码是哪个应用的
            Cachelper.StringSet<string>(appCachekey, appHsSetting.ClientId, TimeSpan.FromMinutes(10));
            //创建全局会话
            var sessionCode = $"SessionCode:{code}";
            var sessionCodeUser = new SessionCodeUser
            {
                ExpiresTime = DateTime.Now.AddHours(1),
                CurrentUser = currentUserModel
            };
            Cachelper.StringSet<CurrentUserModel>(sessionCode, currentUserModel, TimeSpan.FromDays(1));
            //全局会话过期时间
            var sessionExpiryKey = $"SessionExpiryKey:{code}";
            var sessionExpirTime = DateTime.Now.AddDays(1);
            Cachelper.StringSet<DateTime>(sessionExpiryKey, sessionExpirTime, TimeSpan.FromDays(1));
            Console.WriteLine($"登录成功，全局会话code:{code}");
            //缓存授权码取token时最长的有效时间
            Cachelper.StringSet<DateTime>($"AuthCodeSessionTime:{code}", sessionExpirTime, TimeSpan.FromDays(1));
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identity.AddClaim(new Claim(ClaimTypes.Name, userName));
            result.SetSuccess(code);
            return result;
        }

        /// <summary>
        /// 根据会话code获取授权码
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="sessionCode"></param>
        /// <returns></returns>
        public ResponseModel<string> GetCodeBySessionCode(string clientId, string sessionCode)
        {
            var result = new ResponseModel<string>();
            var appHsSetting = ApplicationService.GetApplication(clientId);
            //从配置文件获取应用信息
            //var appHsSetting = AppSettingOptions.Value.appHSSettings.FirstOrDefault(s => s.clientId == clientId);
            if (appHsSetting == null)
            {
                result.SetFail("应用不存在");
                return result;
            }
            var codeKey = $"SessionCode:{sessionCode}";
            var currentUserModel = Cachelper.StringGet<CurrentUserModel>(codeKey);
            if (currentUserModel == null)
            {
                return result.SetFail("会话不存在或已过期", string.Empty);
            }

            //生成授权码
            var code = Guid.NewGuid().ToString().Replace("-", "").ToUpper();
            var key = $"AuthCode:{code}";
            var appCachekey = $"AuthCodeClientId:{code}";
            //缓存授权码
            Cachelper.StringSet<CurrentUserModel>(key, currentUserModel, TimeSpan.FromMinutes(10));
            //缓存授权码是哪个应用的
            Cachelper.StringSet<string>(appCachekey, appHsSetting.ClientId, TimeSpan.FromMinutes(10));

            //缓存授权码取token时最长的有效时间
            var expirTime = Cachelper.StringGet<DateTime>($"SessionExpiryKey:{sessionCode}");
            Cachelper.StringSet<DateTime>($"AuthCodeSessionTime:{code}", expirTime, expirTime - DateTime.Now);

            result.SetSuccess(code);
            return result;

        }

        /// <summary>
        /// 根据刷新Token获取Token
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public string GetTokenByRefresh(string refreshToken, string clientId)
        {
            //刷新Token是否在缓存
            var currentUserModel = Cachelper.StringGet<CurrentUserModel>($"RefreshToken:{refreshToken}");
            if(currentUserModel==null)
            {
                return string.Empty;
            }
            //刷新token过期时间
            var refreshTokenExpiry = Cachelper.StringGet<DateTime>($"RefreshTokenExpiry:{refreshToken}");
            //token默认时间为600s
            double tokenExpiry = 600;
            //如果刷新token的过期时间不到600s了，token过期时间为刷新token的过期时间
            if(refreshTokenExpiry>DateTime.Now&&refreshTokenExpiry<DateTime.Now.AddSeconds(600))
            {
                tokenExpiry = (refreshTokenExpiry - DateTime.Now).TotalSeconds;
            }

                //从新生成Token
                var token = IssueToken(currentUserModel, clientId, tokenExpiry);
                return token;

        }

        /// <summary>
        /// 根据授权码,获取Token
        /// </summary>
        /// <param name="authCode"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public ResponseModel<GetTokenDto> GetTokenWithRefresh(string authCode)
        {
            var result = new ResponseModel<GetTokenDto>();

            var key = $"AuthCode:{authCode}";
            var clientIdCachekey = $"AuthCodeClientId:{authCode}";
            var authCodeSessionTimeKey = $"AuthCodeSessionTime:{authCode}";

            //根据授权码获取用户信息
            var currentUserModel = Cachelper.StringGet<CurrentUserModel>(key);
            //这里报错，后期修改
            //if (currentUserModel == null)
            //{
            //    throw new Exception("code无效");
            //}
            //清除authCode，只能用一次
            Cachelper.DeleteKey(key);

            //获取应用配置
            var clientId = Cachelper.StringGet<string>(clientIdCachekey);
            //刷新token过期时间
            var sessionExpiryTime = Cachelper.StringGet<DateTime>(authCodeSessionTimeKey);
            var tokenExpiryTime = DateTime.Now.AddMinutes(10);//token过期时间10分钟
             //如果刷新token有过期期比token默认时间短，把token过期时间设成和刷新token一样
            if (sessionExpiryTime > DateTime.Now && sessionExpiryTime < tokenExpiryTime)
            {
                tokenExpiryTime = sessionExpiryTime;
            }
            //获取访问token
            var token = this.IssueToken(currentUserModel, clientId, (sessionExpiryTime - DateTime.Now).TotalSeconds);


            TimeSpan refreshTokenExpiry;
            if (sessionExpiryTime != default(DateTime))
            {
                refreshTokenExpiry = sessionExpiryTime - DateTime.Now;
            }
            else
            {
                refreshTokenExpiry = TimeSpan.FromSeconds(60 * 60 * 24);//默认24小时
            }
            //获取刷新token
            var refreshToken = this.IssueToken(currentUserModel, clientId, refreshTokenExpiry.TotalSeconds);
            //缓存刷新token
            Cachelper.StringSet($"RefreshToken:{refreshToken}", currentUserModel, refreshTokenExpiry);
            //缓存刷新token过期时间
            Cachelper.StringSet($"RefreshTokenExpiry:{refreshToken}",DateTime.Now.AddSeconds(refreshTokenExpiry.TotalSeconds), refreshTokenExpiry);
            result.SetSuccess(new GetTokenDto() { Token = token, RefreshToken = refreshToken, Expires = 60 * 10 , Scope = ""});
            Console.WriteLine($"client_id:{clientId}获取token,有效期:{sessionExpiryTime:yyyy-MM-dd HH:mm:ss},token:{token}");
            return result;
        }

        #region private
        /// <summary>
        /// 签发token
        /// </summary>
        /// <param name="userModel"></param>
        /// <param name="clientId"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        private string IssueToken(CurrentUserModel userModel, string clientId, double second = 600)
        {
            var claims = new[]
            {
                   new Claim(ClaimTypes.Name, ""),
                   //new Claim(ClaimTypes.Name, userModel.Name),
                   //new Claim("Account", userModel.Account),
                   //new Claim("Id", userModel.Id.ToString()),
                   //new Claim("Mobile", userModel.Mobile),
                   //new Claim(ClaimTypes.Role,userModel.Role),
            };
            //var appHSSetting = getAppInfoByAppKey(clientId);
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(appHSSetting.clientSecret));
            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var creds = GetCreds(clientId);
            /**
             * Claims (Payload)
                Claims 部分包含了一些跟这个 token 有关的重要信息。 JWT 标准规定了一些字段，下面节选一些字段:
                iss: The issuer of the token，签发主体，谁给的
                sub: The subject of the token，token 主题
                aud: 接收对象，给谁的
                exp: Expiration Time。 token 过期时间，Unix 时间戳格式
                iat: Issued At。 token 创建时间， Unix 时间戳格式
                jti: JWT ID。针对当前 token 的唯一标识
                除了规定的字段外，可以包含其他任何 JSON 兼容的字段。
             * */
            var token = new JwtSecurityToken(
                issuer: "SSOCenter", //谁给的
                audience: clientId, //给谁的
                claims: claims,
                expires: DateTime.Now.AddSeconds(second),//token有效期
                notBefore: null,//立即生效  DateTime.Now.AddMilliseconds(30),//30s后有效
                signingCredentials: creds);
            var returnToken = new JwtSecurityTokenHandler().WriteToken(token);
            return returnToken;
        }

        /// <summary>
        /// 根据appKey获取应用信息
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        private AppHSSetting GetAppInfoByAppKey(string clientId)
        {
            var appHsSetting = AppSettingOptions.Value.appHSSettings.FirstOrDefault(s => s.clientId == clientId);
            return appHsSetting;
        }

        /// <summary>
        /// 获取加密方式
        /// </summary>
        /// <returns></returns>
        protected abstract SigningCredentials GetCreds(string clientId);
        
        #endregion
    }
}
