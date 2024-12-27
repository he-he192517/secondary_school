using System.Linq;
using System.Threading.Tasks;
using Furion.Authorization;
using FurSystemTest.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;

namespace FurSystemTest.Web.Core;

/// <summary>
/// JWT 授权自定义处理程序
/// </summary>
public class JwtHandler : AppAuthorizeHandler
{
    //PipelineAsync进入的时候已经完成了基本的验证，能确定该用户已经登录了，返回值是一个bool。
    public override Task<bool> PipelineAsync(AuthorizationHandlerContext context, DefaultHttpContext httpContext)
    {

        var roleName = context.User.Claims.FirstOrDefault(tp => tp.Type == "Role")?.Value;

        //逻辑错误导致不能出现MainLayout
        //if (string.IsNullOrEmpty(roleName))
        //{
        //    return Task.FromResult(false);
        //}


        if (context.Resource is RouteData routeData)
        {
            var routeAttr = routeData.PageType.CustomAttributes.FirstOrDefault(x =>
                x.AttributeType == typeof(RouteAttribute));
            if (routeAttr == null)
            {
                return Task.FromResult(true);
            }
            else
            {
                //是routeData的检查权限，角色权限在页面上（基于路由）
                var url = routeAttr.ConstructorArguments[0].Value as string;
                //var permission = MenuEntity
                //    .Where(x => x.Roles!.Any(y => y.Id == roleId) && x.Url == url).First();
                //if (permission != null)
                //{
                //    return Task.FromResult(true);
                //}

                return Task.FromResult(true);
            }
        }
        //不是routeData的全部通过
        else
        {
            return Task.FromResult(true);
        }
    }
}

