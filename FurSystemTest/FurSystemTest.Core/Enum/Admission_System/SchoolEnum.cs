using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Enum.Admission_System
{
    public enum SchoolTypeEnum
    {
        /// <summary>
        /// 高中
        /// </summary>
        [Display(Name = "高中")]
        HighSchool = 1,
        /// <summary>
        /// 初中
        /// </summary>
        [Display(Name = "初中")]
        JuniorHighSchool = 2,
        /// <summary>
        /// 混合
        /// </summary>
        [Display(Name = "混合")]
        Mixed = 3
    }
    public enum Grade
    {
        /// <summary>
        /// 高一
        /// </summary>
        [Display(Name = "高一")]
        Grade1 = 1,
        /// <summary>
        /// 高二
        /// </summary>
        [Display(Name = "高二")]
        Grade2 = 2,
        /// <summary>
        /// 高三
        /// </summary>
        [Display(Name = "高三")]
        Grade3 = 3,
        /// <summary>
        /// 初一
        /// </summary>
        [Display(Name = "初一")]
        Grade4 = 4,
        /// <summary>
        /// 初二
        /// </summary>
        [Display(Name = "初二")]
        Grade5 = 5,
        /// <summary>
        /// 初三
        /// </summary>
        [Display(Name = "初三")]
        Grade6 = 6
    }
}
