using SqlSugar;

namespace FurSystemTest.Core;

/// <summary>
/// 角色和权限关系表
/// </summary>
/// 
[SugarTable("RoleSecurity")]
public class RoleSecurity 
{
    /// <summary>
    /// 角色Id
    /// </summary>
    [SugarColumn(IsPrimaryKey = true)]
    public int RoleId { get; set; }

    /// <summary>
    /// 权限Id
    /// </summary>
    [SugarColumn(IsPrimaryKey = true)]
    public int SecurityId { get; set; }

  
}
