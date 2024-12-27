using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FurSystemTest.Core.Enum.Admission_System
{
    public enum NoticeType
    {
        /// <summary>
        /// 未确认
        /// </summary>
        [Display(Name = "未确认")]
        Unconfirmed = 0,
        /// <summary>
        /// 已确认
        /// </summary>
        [Display(Name = "未确认")]
        Confirmed = 1
    }
}
