using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    /// <summary>
    /// 开课计划表
    /// </summary>
    [SugarTable("course_plans")]
    public class CoursePlan
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "PlanID")]
        public int PlanId { get; set; }

        /// <summary>
        /// 学科ID
        /// </summary>
        [SugarColumn(ColumnName = "SubjectID")]
        [Description("学科")]
        public int SubjectId { get; set; }

        /// <summary>
        /// 班级ID
        /// </summary>
        [SugarColumn(ColumnName = "ClassId")]
        [Description("班级")]
        public int ClassId { get; set; }

        /// <summary>
        /// 上课时间ID
        /// </summary>
        [SugarColumn(ColumnName = "ScheduleID")]
        [Description("上课时间")]
        public int ScheduleId { get; set; }

        /// <summary>
        /// 教师ID
        /// </summary>
        [SugarColumn(ColumnName = "TeacherID")]
        [Description("教师")]
        public int TeacherId { get; set; }

        /// <summary>
        /// 星期几
        /// </summary>
        [SugarColumn(ColumnDataType = "enum", ColumnName = "DayOfWeek")]
        [Description("星期几")]
        public DayOfWeekEnum DayOfWeek { get; set; }  // Enum 类型

        // 可根据需求定义枚举
        public enum DayOfWeekEnum
        {
            星期一,
            星期二,
            星期三,
            星期四,
            星期五,
            星期六,
            星期天
        }
    }
}
