using SqlSugar;

namespace FurSystemTest.Core;

/// <summary>
/// 角色表
/// </summary>
[SugarTable("Role")]
public class Role
{
    [SugarColumn(IsPrimaryKey = true)]
    public int RoleId { get; set; }
    /// <summary>
    /// 角色名称
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 角色描述
    /// </summary>
    public string Remark { get; set; }

}


