using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Enum.Admission_System;

namespace FurSystemTest.Core.Entites.Admission_System
{
    /// <summary>
    /// 录取表
    /// </summary>
    [SugarTable("Admissions")]
    public class Admission
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "AdmissionID")]
        public int AdmissionId { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        [SugarColumn(ColumnName = "StudentID")]
        [Description("学生姓名")]
        public int? StudentId { get; set; }

        /// <summary>
        /// 总分
        /// </summary>
        [SugarColumn(ColumnDataType = "decimal", ColumnName = "TotalScore")]
        [Description("总分")]
        public decimal TotalScore { get; set; }

        /// <summary>
        /// 录取院校
        /// </summary>
        [SugarColumn(ColumnDataType = "int", ColumnName = "AdmittedSchool")]
        [Description("录取院校")]
        public int AdmittedSchool { get; set; }

        /// <summary>
        /// 录取通知书确认状态
        /// </summary>
        [SugarColumn(ColumnDataType = "int", ColumnName = "AdmissionNoticeConfirmed")]
        [Description("录取通知书确认状态")]
        public NoticeType AdmissionNoticeConfirmed { get; set; } = NoticeType.Unconfirmed;

        /// <summary>
        /// 录取时间
        /// </summary>
        [SugarColumn(ColumnDataType = "datetime", ColumnName = "AdmissionTime")]
        [Description("录取时间")]
        public DateTime AdmissionTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 班级
        /// </summary>
        [SugarColumn(ColumnName = "ClassId")]
        [Description("学校名称")]
        public int ClassId { get; set; }
    }
}
