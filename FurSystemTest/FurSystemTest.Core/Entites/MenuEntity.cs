using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace FurSystemTest.Core.Entites;

/// <summary>
/// 菜单表
/// </summary>
[SugarTable("menus")]
public class MenuEntity
{

    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int Id { get; set; } = 0;

    [Description("菜单名")]
    [Required(ErrorMessage = "菜单名不能为空")]
    public string? MenuName { get; set; }

    [Description("Url")]
    [Required(ErrorMessage = "Url不能为空")]
    public string? Url { get; set; }

    [Description("图标")]
    [Required(ErrorMessage = "图标不能为空")]
    public string? Icon { get; set; }

    public int ParentId { get; set; }

    public string? ClientId { get; set; }

}

