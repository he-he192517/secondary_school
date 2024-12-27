using System.ComponentModel.DataAnnotations;


namespace FurSystemTest.Core
{
    //是否
    public enum Whether
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "是")]
        Yes = 1,

        [Display(Name = "否")]
        No = 2,

    }

    //民族
    public enum NaTion_ba
    {
        [Display(Name = "请选择")]
        Null = 9,
        [Display(Name = "汉族")]
        one = 1,
        [Display(Name = "蒙古族")]
        two = 2,
        [Display(Name = "藏族")]
        three = 3,
        [Display(Name = "壮族")]
        four = 4,
        [Display(Name = "回族")]
        five = 5,
        [Display(Name = "满族")]
        six = 6,
        [Display(Name = "维吾尔族")]
        seven = 7,
        [Display(Name = "其他")]
        eight = 8,
    }

    //戴镜类型
    public enum GlassType_ba
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "框架眼镜")]
        one = 1,

        [Display(Name = "隐形眼镜")]
        two = 2,

        [Display(Name = "夜戴角膜塑性镜，佩戴度数")]
        three = 3,

        [Display(Name = "不戴镜")]
        four = 4,

    }

    //前屈实验
    public enum Qianqsy_ba
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "无侧弯")]
        one = 1,

        [Display(Name = "左低右高")]
        two = 2,

        [Display(Name = "右低左高")]
        three = 3,
    }

    //一般检查
    public enum Yibanjc_ba
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "正常")]
        one = 1,

        [Display(Name = "前凸体征")]
        two = 2,

        [Display(Name = "后凸体征")]
        three = 3,
    }

    //俯卧实验
    public enum Fuwosy_ba
    {
        [Display(Name = "请选择")]
        Null = 9,

        [Display(Name = "前凸体征消失")]
        one = 1,

        [Display(Name = "前凸体征")]
        two = 2,

        [Display(Name = "后凸体征")]
        three = 3,
    }
}