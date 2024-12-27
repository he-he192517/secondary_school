namespace FurSystemTest.Core;

/// <summary>
/// 权限管理器
/// </summary>
public interface IAuthorizationManager
{
    /// <summary>
    /// 获取用户 Id
    /// </summary>
    /// <returns></returns>
    int GetUserId();

    /// <summary>
    /// 检查授权，资源id根据需要可以对应到数据库中的security表的UniqueName
    /// </summary>
    /// <param name="resourceId"></param>
    /// <returns></returns>
    bool CheckSecurity(string resourceId);
}
