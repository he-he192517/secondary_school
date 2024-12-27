using Furion;
using Furion.DependencyInjection;
using SqlSugar;
using System;
using System.Linq;
using System.Security.Claims;

namespace FurSystemTest.Core;

/// <summary>
/// 权限管理器
/// </summary>
public class AuthorizationManager : IAuthorizationManager, ITransient
{
    /// <summary>
    /// 数据库上下文
    /// </summary>
    private readonly ISqlSugarClient _db=DbContext.Instance;

    /// <summary>
    /// 获取用户Id
    /// </summary>
    /// <returns></returns>
    public int GetUserId()
    {
        return int.Parse(App.User.FindFirstValue("UserId"));
    }

    /// <summary>
    /// 检查权限
    /// </summary>
    /// <param name="resourceId"></param>
    /// <returns></returns>
    public bool CheckSecurity(string resourceId)
    {
        var userId = GetUserId();

        // ========= 以下代码应该缓存起来 ===========
        //获取该用户对应的角色及其该角色对应的权限
        //可以获取security的UniqueName或者Id进行比对

        var securities=_db.Queryable<User,Role,UserRole,RoleSecurity,Security>((u,r,ur,rs,s)=>new JoinQueryInfos(
                       JoinType.Inner,u.UserId==ur.UserId,
                                  JoinType.Inner,r.RoleId==ur.RoleId,
                                  JoinType.Inner,r.RoleId==rs.RoleId
                                             ))
            .Where((u,r,ur,rs,s)=>u.UserId==userId)
            .Select((u,r,ur,rs,s)=>s.UniqueName).Distinct()
            .ToList();

        if (!securities.Contains(resourceId)) return false;

        return true;
    }
}
