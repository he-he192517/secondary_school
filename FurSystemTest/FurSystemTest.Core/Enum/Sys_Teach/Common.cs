using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Enum.Sys_Teach
{
    /// <summary>
    /// 民族
    /// </summary>
    public enum Ethnicity
    {
        [Display(Name = "汉族")]
        Hanzu = 1,

        [Display(Name = "蒙古族")]
        Mongzu = 2,

        [Display(Name = "回族")]
        Huizu = 3,

        [Display(Name = "藏族")]
        Zangzu = 4,

        [Display(Name = "维吾尔族")]
        Weiwuerzu = 5,

        [Display(Name = "苗族")]
        Miaozu = 6,

        [Display(Name = "彝族")]
        Yizu = 7,

        [Display(Name = "壮族")]
        Zhuangzu = 8,

        [Display(Name = "布依族")]
        Buyizu = 9,

        [Display(Name = "朝鲜族")]
        Chaoxianzu = 10,

        [Display(Name = "满族")]
        Manzu = 11,

        [Display(Name = "侗族")]
        Dongzu = 12,

        [Display(Name = "瑶族")]
        Yaozu = 13,

        [Display(Name = "白族")]
        Baizu = 14,

        [Display(Name = "土家族")]
        Tujiazu = 15,

        [Display(Name = "哈尼族")]
        Haniezu = 16,

        [Display(Name = "哈萨克族")]
        Hasakezu = 17,

        [Display(Name = "傣族")]
        Daizu = 18,

        [Display(Name = "黎族")]
        Lizu = 19,

        [Display(Name = "傈僳族")]
        Lisu = 20,

        [Display(Name = "佤族")]
        Wazu = 21,

        [Display(Name = "畲族")]
        Shezu = 22,

        [Display(Name = "高山族")]
        Gaoshanzu = 23,

        [Display(Name = "拉祜族")]
        Lahuzu = 24,

        [Display(Name = "水族")]
        Shuizu = 25,

        [Display(Name = "东乡族")]
        Dongxiangzu = 26,

        [Display(Name = "纳西族")]
        Naxi = 27,

        [Display(Name = "景颇族")]
        Jingpozhu = 28,

        [Display(Name = "柯尔克孜族")]
        Keerkezizu = 29,

        [Display(Name = "土族")]
        Tuzhu = 30,

        [Display(Name = "达斡尔族")]
        Daweierzu = 31,

        [Display(Name = "仫佬族")]
        Mulaozu = 32,

        [Display(Name = "羌族")]
        Qiangzu = 33,

        [Display(Name = "布朗族")]
        Bulangzu = 34,

        [Display(Name = "撒拉族")]
        Salazu = 35,

        [Display(Name = "毛南族")]
        Maonanzu = 36,

        [Display(Name = "仡佬族")]
        Gelaozu = 37,

        [Display(Name = "锡伯族")]
        Xibo = 38,

        [Display(Name = "阿昌族")]
        Achangzu = 39,

        [Display(Name = "普米族")]
        Pumi = 40,

        [Display(Name = "塔吉克族")]
        Tajikezu = 41,

        [Display(Name = "怒族")]
        Nuzu = 42,

        [Display(Name = "乌孜别克族")]
        Wuzibiekezu = 43,

        [Display(Name = "俄罗斯族")]
        Eluosi = 44,

        [Display(Name = "鄂温克族")]
        Ewenke = 45,

        [Display(Name = "德昂族")]
        Deangzu = 46,

        [Display(Name = "保安族")]
        Baoanzu = 47,

        [Display(Name = "裕固族")]
        Yugu = 48,

        [Display(Name = "京族")]
        Jingzu = 49,

        [Display(Name = "塔塔尔族")]
        Tataerzu = 50,

        [Display(Name = "独龙族")]
        Dulongzu = 51,

        [Display(Name = "鄂伦春族")]
        Elunchunzu = 52,

        [Display(Name = "赫哲族")]
        Hezhezu = 53,

        [Display(Name = "门巴族")]
        Menbazu = 54,

        [Display(Name = "珞巴族")]
        Luobazu = 55,

        [Display(Name = "基诺族")]
        Jinuozu = 56,

        [Display(Name = "未定族称人口")]
        Weidingzucheng = 97,

        [Display(Name = "入籍")]
        Rujizucheng = 98
    }

    public enum ExamStaus
    {
        [Display(Name = "正常")]
        Normal = 1,

        [Display(Name = "作弊")]
        Cheating = 2,

        [Display(Name = "缺考")]
        Absent = 3,

        [Display(Name = "无效")]
        Invalid = 4
    }

    public enum PositionType
    {
        [Display(Name = "学科教师")]
        SubjectTeacher = 1,

        [Display(Name = "教务员")]
        AcademicClerk = 2,

        [Display(Name = "实验员/实验室管理员")]
        LabTechnician = 3,

        [Display(Name = "校长/副校长")]
        PrincipalVicePrincipal = 4,

        [Display(Name = "教务主任/年级主任")]
        AcademicDirectorGradeHead = 5
    }

    public enum DepartmentType
    {
        [Display(Name = "校长办公室")]
        SubjectTeacher = 1,

        [Display(Name = "教务处")]
        AcademicClerk = 2,

        [Display(Name = "学工处")]
        LabTechnician = 3,

        [Display(Name = "教师队伍")]
        PrincipalVicePrincipal = 4,

        [Display(Name = "班主任")]
        AcademicDirectorGradeHead = 5
    }

    /// <summary>
    /// 调动类型
    /// </summary>
    public enum TransferType
    {
        /// <summary>
        /// 职位变动
        /// </summary>
        [Display(Name = "职位变动")]
        PositionChange = 1,

        /// <summary>
        /// 部门变动
        /// </summary>
        [Display(Name = "部门变动")]
        DepartmentChange = 2
    }

    /// <summary>
    /// 调动状态枚举
    /// </summary>
    public enum TransferStatus
    {
        [Display(Name = "待处理")]
        Pending = 1,      // 调动请求已提交，但尚未处理。

        [Display(Name = "已批准")]
        Approved = 2,     // 调动请求已获批准。

        [Display(Name = "已拒绝")]
        Rejected = 3,     // 调动请求被拒绝。

        [Display(Name = "已完成")]
        Completed = 4,    // 调动已成功执行。

        [Display(Name = "已取消")]
        Cancelled = 5      // 调动请求已被取消。
    }
}
