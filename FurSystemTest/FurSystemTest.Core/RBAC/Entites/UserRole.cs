using SqlSugar;

namespace FurSystemTest.Core;

/// <summary>
/// 用户和角色关系表
/// </summary>
[SugarTable("UserRole")]
public class UserRole
{
    /// <summary>
    /// 用户Id
    /// </summary>
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int UserId { get; set; }

    /// <summary>
    /// 角色Id
    /// </summary>
    [SugarColumn(IsPrimaryKey = true)]
    public int RoleId { get; set; }


}
