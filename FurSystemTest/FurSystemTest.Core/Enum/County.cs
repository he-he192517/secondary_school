using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FurSystemTest.Core
{
    public enum County
    {
        [Display(Name = "请选择")]
        Null = 99,

        [Display(Name = "吉阳区")]
        jiyang_district = 61,

        [Display(Name = "天涯区")]
        tianya_district = 62,

        [Display(Name = "崖州区")]
        yazhou_district = 63,

        [Display(Name = "海棠区")]
        haitang_district = 64,

        [Display(Name = "秀英区")]
        xiuying_district = 51,

        [Display(Name = "琼山区")]
        qiongshan_district = 53,

        [Display(Name = "龙华区")]
        longhua_district = 52,

        [Display(Name = "美兰区")]
        meilan_district = 54,

        [Display(Name = "儋州市")]
        danzhou_city = 71,

        //其他地市
        [Display(Name = "保亭")]
        baoting_county = 17,

        [Display(Name = "琼中")]
        qiongzhong_county = 18,

        [Display(Name = "万宁市")]
        wanning_city = 07,

        [Display(Name = "屯昌")]
        tunchang_county = 10,

        [Display(Name = "五指山")]
        wuzhishan_city = 04,

        [Display(Name = "东方")]
        dongfang_city = 08,

        [Display(Name = "陵水")]
        lingshui_county = 16,

        [Display(Name = "琼海")]
        qionghai_city = 05,

        [Display(Name = "文昌")]
        wenchang_city = 06,

        [Display(Name = "定安")]
        dingan_county = 09,

        [Display(Name = "澄迈")]
        chengmai_county = 11,

        [Display(Name = "白沙")]
        baisha_county = 13,

        [Display(Name = "昌江")]
        changjiang_county = 14,

        [Display(Name = "乐东")]
        ledong_county = 15,

        [Display(Name = "临高")]
        lingao_county = 19,

        [Display(Name = "永兴")]
        yongxing_county = 00,
    }
}
