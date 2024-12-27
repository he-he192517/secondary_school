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
    /// 作息时间表
    /// </summary>
    [SugarTable("daily_schedule")]
    public class DailySchedule
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ScheduleID")]
        public int ScheduleId { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(100)", ColumnName = "ActivityName")]
        [Description("活动名称")]
        public string ActivityName { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [SugarColumn(ColumnDataType = "time", ColumnName = "StartTime")]
        [Description("开始时间")]
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [SugarColumn(ColumnDataType = "time", ColumnName = "EndTime")]
        [Description("结束时间")]
        public TimeSpan EndTime { get; set; }
    }
}
