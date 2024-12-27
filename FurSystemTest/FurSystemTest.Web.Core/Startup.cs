using System;
using Furion;
using FurSystemTest.Application;
using FurSystemTest.Application.RBAC;
using FurSystemTest.Application.Util;
using FurSystemTest.Core.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FurSystemTest.Web.Core
{
    public class Startup : AppStartup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddConsoleFormatter();

            // 增加Jwt和Cookie混合认证
            services.AddJwt(options =>
            {
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;    // 更改默认验证为 Cookies
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;   // 更改默认验证为 Cookies
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options =>
            {
                options.Cookie.Name = "FurionSystem";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
                options.SlidingExpiration = true;
                options.LoginPath = "/Account/Login";
            });

            //配置redis缓存
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = "localhost:6379,password=rootroot";
                options.InstanceName = "FurionSystem";
            });
            // 增加授权码模式
            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = "oidc"; 
            })
                .AddOpenIdConnect("oidc", options =>
                {
                    options.Authority = "https://www.sso.com";
                    options.ClientId = "client-id";
                    options.ClientSecret = "client-secret";
                    options.ResponseType = "code";
                    options.SaveTokens = true;
                    options.Scope.Add("api1");
                    options.Scope.Add("offline_access");
                });

            services.AddAuthorization();
            services.AddSession();
            services.AddHttpContextAccessor(); // 只需要注册一次
            services.AddFileLogging();

            // 选项注册
            services.AddConfigurableOptions<AppInfoOptions>();

            services.AddControllers().AddInjectWithUnifyResult();
            services.AddRazorPages();
            services.AddServerSideBlazor();

            //添加远程服务
            services.AddRemoteRequest();

            // 注册Cachelper
            services.AddTransient<Cachelper>();
            // 注册 SsoService
            services.AddTransient<SsoService>();
            services.AddTransient<IApplicationService, ApplicationService>();

            // 添加本行代码
            services.AddBootstrapBlazor();
            services.ConfigureJsonLocalizationOptions(options =>
            {
                // 忽略本地化键值文化信息丢失
                options.IgnoreLocalizerMissing = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseSession();

            app.UseAuthentication(); // 添加认证中间件
            app.UseAuthorization(); // 添加授权中间件

            app.UseInject();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}