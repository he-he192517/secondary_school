using SqlSugar;

namespace FurSystemTest.Core;

/// <summary>
/// 用户表
/// </summary>
[SugarTable("user")]
public class User 
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int UserId { get; set; }

    /// <summary>
    /// 名称
    /// </summary>
    [SugarColumn(ColumnDataType = "varchar(30)", ColumnName = "UserName")]
    public string UserName { get; set; }

    /// <summary>
    /// 账号
    /// </summary>
    [SugarColumn(ColumnDataType = "varchar(20)", ColumnName ="Account")]
    public string Account { get; set; }

    /// <summary>
    /// 密码
    /// </summary>
    [SugarColumn(ColumnDataType = "varchar(32)", ColumnName = "Password")]
    public string Password { get; set; }

    /// <summary>
    /// 手机号
    /// </summary>
    [SugarColumn(ColumnDataType = "varchar(20)", ColumnName = "Mobile")]
    public string Mobile { get; set; }

    /// <summary>
    /// 状态
    /// </summary>
    [SugarColumn(ColumnDataType = "int", ColumnName = "Status")]
    public int Status { get; set; } = 1;
}
