using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Enum.Admission_System
{
    public enum GenderType
    {
        /// <summary>
        /// 男
        /// </summary>
        [Display(Name = "男")]
        Man = 1,
        /// <summary>
        /// 女
        /// </summary>
        [Display(Name = "女")]
        Women = 2
    }
}
