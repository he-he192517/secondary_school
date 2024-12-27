using SqlSugar;

namespace FurSystemTest.Core;

/// <summary>
/// 权限表
/// </summary>
[SugarTable("Security")]
public class Security 
{
    [SugarColumn(IsPrimaryKey = true)]
    public int SecurityId { get; set; }
    /// <summary>
    /// 权限唯一名（每一个接口）
    /// </summary>
    public string UniqueName { get; set; }

    //如果是菜单项，可以保存UrlValue，UrlText保存菜单中文名
   public string UrlValue { get; set; }

    //UrlText保存菜单的中文名
   public string UrlText { get; set; }
}
