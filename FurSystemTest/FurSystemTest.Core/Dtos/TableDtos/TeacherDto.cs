using FurSystemTest.Core.Enum.Sys_Teach;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Dtos.TableDtos
{
    internal class TeacherDto { 
    

        /// <summary>
        /// 教师姓名
        /// </summary>
        [Description("教师姓名")]
        public string TeacherName { get; set; }

        /// <summary>
        /// 入编年份
        /// </summary>
        [Description("入编年份")]
        public DateTime EntryYear { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [Description("激活状态")]
        public bool IsActive { get; set; } = true; // 默认值为1（激活）

        /// <summary>
        /// 职务
        /// </summary>
        [SugarColumn(ColumnName = "职务")]
        public int Position { get; set; } // 职务字段

        /// <summary>
        /// 所在部门
        /// </summary>
        [SugarColumn(ColumnName = "DepartmentId")]
        [Description("所在部门")]
        public int DepartmentId { get; set; } // 外键，指向部门表
    }
}
