using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core
{
    //模版类型
    public enum ModelType
    {
        [Display(Name = "请选择导入模板类型")]
        Type0 = 0,
        [Display(Name = "表1-1 省、地市及区（县）管理部门学校卫生工作调查表")]
        Type1 = 1,
        [Display(Name = "表1-2 中小学校开展学校卫生工作情况调查表")]
        Type2 = 2,
        [Display(Name = "表1-3 学校教学生活环境卫生监测调查表")]
        Type3 = 3,
        [Display(Name = "表2-1 学生重点常见病监测表（中小学生版）")]
        Type4 = 4,
        [Display(Name = "表2-2 学生重点常见病监测表（大学生版）")]
        Type5 = 5,
        [Display(Name = "表2-3 学生重点常见病监测表（幼儿园版）")]
        Type6 = 6,
        [Display(Name = "表3-1 学生健康状况及影响因素调查表（小学版）")]
        Type7 = 7,
        [Display(Name = "表3-2 学生健康状况及影响因素调查表（中学版）")]
        Type8 = 8,
        [Display(Name = "表3-3 学生健康状况及影响因素调查表（大学版）")]
        Type9 = 9,
    }

    //是否在用，在用/禁用
    public enum IsUsed
    {
        //在用
        [Display(Name = "在用")]
        Used = 1,
        //禁用
        [Display(Name = "禁用")]
        NotUsed = 0,
    }

    //软删除状态
    public enum IsDeleted
    {
        //未删除
        [Display(Name = "未删除")]
        NotDeleted = 1,
        //已删除
        [Display(Name = "已删除")]
        Deleted = 0,
    }


    public enum Province
    {
        [Display(Name = "海南省")]
        HaiNan = 46,
    }


    public enum Point
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "城区")]
        Urban = 1,
        [Display(Name = "郊区")]
        Suburbs = 2
    }

    //前面要补充0
    public enum City
    {
        [Display(Name = "请选择")]
        Null = 99,
        [Display(Name = "其他地市")]
        Other= 0,
        [Display(Name = "海口")]
        HaiKou = 01,
        [Display(Name = "三亚市")]
        SanYa = 02,
        [Display(Name = "儋州市")]
        DanZhou = 03,
        [Display(Name = "三沙")]
        SanSha = 12,
    }

    //public static class EnumExtensions
    //{
    //    public static string GetDisplayName(this Enum value)
    //    {
    //        var fieldInfo = value.GetType().GetField(value.ToString());
    //        var displayAttribute = fieldInfo.GetCustomAttributes(false)
    //            .OfType<DisplayAttribute>()
    //            .SingleOrDefault();

    //        return displayAttribute?.Name ?? value.ToString();
    //    }
    //}
}
