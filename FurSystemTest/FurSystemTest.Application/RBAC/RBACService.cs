using System.Security.Claims;
using Furion.JsonSerialization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace FurSystemTest.Application.RBAC;

/// <summary>
/// 角色管理服务
/// </summary>
//[AppAuthorize]
public class RbacService : IDynamicApiController, ITransient
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ISqlSugarClient _db = DbContext.Instance;
    private readonly IAuthorizationManager _authManager;

    public RbacService(IHttpContextAccessor httpContextAccessor,IAuthorizationManager authManager)
    {
        _httpContextAccessor = httpContextAccessor;
        _authManager = authManager;

    }

    /// <summary>
    /// 登录（免授权）
    /// </summary>
    /// <param name="input"></param>
    /// <remarks>管理员：admin/admin；普通用户：Furion/dotnetchina</remarks>
    /// <returns></returns>
    [AllowAnonymous]
    public async Task<string> Login(LoginInput input)
    {

        // 验证用户名和密码，必须对数据进行验证

        var user = _db.Queryable<User>().First(u => u.Account == input.Account && u.Password == input.Password);
        if (user == null)
        {
            return JSON.Serialize( new { message = "用户名或密码错误", code = 50000 });
        }
        else
        {
            //如果用户存在，获取用户对应的角色信息
            var role = GetRoleByUserId(user.UserId);

            //var output = user.Adapt<LoginOutput>();
            var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);

            identity.AddClaim(new Claim(ClaimConst.Account, user.Account, ClaimValueTypes.String));

            //这里应该从数据库中获取用户的角色信息，然后添加到Claim中
            if (role!=null)
            {
                identity.AddClaim(new Claim(ClaimConst.Role, role.Name, ClaimValueTypes.String));
            }
            else
            {
                identity.AddClaim(new Claim(ClaimConst.Role, "Anonymous", ClaimValueTypes.String));
            }

            identity.AddClaim(new Claim(ClaimConst.Name, value: user.Account));
            identity.AddClaim(new Claim(ClaimConst.UserId, value: user.UserId.ToString()));

            //修改登录状态

            var httpContext = _httpContextAccessor.HttpContext;

            if (httpContext != null)
            {
                await httpContext.SignInAsync(scheme: CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), new AuthenticationProperties());

                return JSON.Serialize( new { code = 20000, massage = "登录成功" });
            }
            else
            {
                return JSON.Serialize( new { message = "httpContext为空，请调整登录方案", code = 51000 });
            }

            //此处已经拿到AccessToken
            //    output.AccessToken = JWTEncryption.Encrypt(new Dictionary<string, object>()
            //{
            //    { "UserId", user.UserId.ToString() },  // 存储Id
            //    { "Account",user.Account}, // 存储用户名
            //    {"Name",user.Account},
            //    {"Role","Admin" },
            //}, 20);
            //return output;
        }
    }
    /// <summary>
    /// 查看用户角色，，也可以考虑使用_authManager读取用户Id
    /// </summary>
    [SecurityDefine(SecurityConst.ViewRoles)]
    public List<RoleDto> ViewRoles()
    {
        //可以使用的方法
        //var userId1 = _authManager.GetUserId();
        
        // 获取用户Id
        var userId = UserManager.UserId;


        var roles = _db.Queryable<User, UserRole, Role>((u, ur, r) => u.UserId == ur.UserId && ur.RoleId == r.RoleId)
            .Select((u, ur, r) => new RoleDto { Id = r.RoleId, Name = r.Name, Remark = r.Remark }).ToList();


        return roles.Adapt<List<RoleDto>>();
    }

    /// <summary>
    /// 查看用户权限，也可以考虑使用_authManager读取用户Id
    /// </summary>
    /// <returns></returns>
    [SecurityDefine(SecurityConst.ViewSecuries)]
    public List<SecurityDto> ViewSecuries()
    {
        // 获取用户Id
        var userId = UserManager.UserId;


        //查询用户权限
        var securities = _db.Queryable<User, UserRole, Role, RoleSecurity, Security>((u, ur, r, rs, s) => u.UserId == ur.UserId &&
        ur.RoleId == r.RoleId && r.RoleId == rs.RoleId && rs.SecurityId == s.SecurityId && u.UserId == userId).Distinct()
            .Select((u, ur, r, rs, s) => new Security { SecurityId = s.SecurityId, UniqueName = s.UniqueName }).ToList();

        return securities.Adapt<List<SecurityDto>>();
    }

    /// <summary>
    /// 角色列表
    /// </summary>
    [SecurityDefine(SecurityConst.GetRoles)]
    public List<RoleDto> GetRoles()
    {
        return _db.Queryable<Role>().Adapt<List<RoleDto>>();
    }

    /// <summary>
    /// 新增角色
    /// </summary>
    [SecurityDefine(SecurityConst.InsertRole)]
    public void InsertRole(RoleInput input)
    {
        _db.Insertable<Role>(input.Adapt<Role>()).ExecuteCommand();

    }

    /// <summary>
    /// 为用户分配角色
    /// </summary>
    [SecurityDefine(SecurityConst.GiveUserRole)]
    public void GiveUserRole(int[] roleIds)
    {
        // 获取用户Id
        var userId = UserManager.UserId;

        roleIds ??= Array.Empty<int>();

        _db.Deleteable<UserRole>().Where(x => x.UserId == userId).ExecuteCommand();


        var list = new List<UserRole>();
        foreach (var roleid in roleIds)
        {
            list.Add(new UserRole { UserId = userId, RoleId = roleid });
        }

        _db.Insertable<UserRole>(list).ExecuteCommand();
    }

    /// <summary>
    /// 查看系统所有的权限（免授权）
    /// </summary>
    [AllowAnonymous]
    public List<SecurityDto> GetSecurities()
    {
        return _db.Queryable<Security>().Adapt<List<SecurityDto>>();
    }

    /// <summary>
    /// 为角色分配权限
    /// </summary>
    [SecurityDefine(SecurityConst.GiveRoleSecurity)]
    public void GiveRoleSecurity(int roleId, int[] securityIds)
    {
        securityIds ??= Array.Empty<int>();

        _db.Deleteable<RoleSecurity>().Where(x => x.RoleId == roleId).ExecuteCommand();

        var list = new List<RoleSecurity>();
        foreach (var securityId in securityIds)
        {
            list.Add(new RoleSecurity { RoleId = roleId, SecurityId = securityId });
        }

        _db.Insertable<RoleSecurity>(list).ExecuteCommand();

    }

    public string GetToken()
    {
        // 获取用户Id

        return JWTEncryption.Encrypt(new Dictionary<string, object>()
        {
            { "UserId", UserManager.UserId },  // 存储Id
            { "Account",UserManager.Account}, // 存储用户名
            {"Name",UserManager.Name},
            {"Role",UserManager.Role },
        }, 20);
    }

    [AllowAnonymous]
    public Task<string> Logout()
    {
        var httpContext = _httpContextAccessor.HttpContext;

        if (httpContext != null)
        {
            httpContext.SignOutAsync(scheme: CookieAuthenticationDefaults.AuthenticationScheme);
        }
        else
        {
            return Task.FromResult("httpContext为空");
        }

        return Task.FromResult("退出成功");
    }

    //根据UserId获取角色信息[一个用户多个角色],此处还没有登录，不能使用UserManager
    private List<Role> GetRolesByUserId(int userId)
    {
        var roles = _db.Queryable<User, UserRole, Role>((u, ur, r) => u.UserId == ur.UserId && ur.RoleId == r.RoleId)
            .Select((u, ur, r) => new Role { RoleId = r.RoleId, Name = r.Name, Remark = r.Remark }).ToList();

        return roles;
    }

    //根据UserId获取角色信息[一个用户一个],此处还没有登录，不能使用UserManager
    private Role GetRoleByUserId(int userId)
    {
        var role = _db.Queryable< Role,UserRole>(( r, ur) => ur.UserId == userId && ur.RoleId == r.RoleId)
            .Select((r,ur) => new Role { RoleId = r.RoleId, Name = r.Name, Remark = r.Remark }).ToList()[0];

        return role;
    }
}