using FurSystemTest.Core.Enum.Sys_Teach;
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
    /// 成绩表
    /// </summary>
    [SugarTable("exam_scores")]
    public class ExamScore
    {
        /// <summary>
        /// 成绩ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ScoreID")]
        public int ScoreId { get; set; }

        /// <summary>
        /// 学号
        /// </summary>
        [SugarColumn(ColumnName = "StudentNumber")]
        [Description("学号")]
        public string StudentNumber { get; set; }


        /// <summary>
        /// 考试名称
        /// </summary>
        [SugarColumn(ColumnName = "SubjectName")]
        [Description("学科名称")]
        public int SubjectName { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [SugarColumn(ColumnName = "ClassName")]
        [Description("班级名称")]
        public int ClassName { get; set; }

        /// <summary>
        /// 教师编号
        /// </summary>
        [SugarColumn(ColumnName = "TeacherID")]
        [Description("教师编号")]
        public int TeacherId { get; set; }

        /// <summary>
        /// 分数
        /// </summary>
        [SugarColumn(ColumnDataType = "decimal(5,2)", ColumnName = "Score")]
        [Description("分数")]
        public decimal? Score { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        [SugarColumn(ColumnDataType = "datetime", ColumnName = "EntryDate", DefaultValue = "CURRENT_TIMESTAMP")]
        [Description("录入时间")]
        public DateTime? EntryDate { get; set; }

        /// <summary>
        /// 考试ID
        /// </summary>
        [SugarColumn(ColumnName = "ExamID")]
        [Description("考试ID")]
        public int ExamId { get; set; }

        [SugarColumn(ColumnDataType = "int")]
        [Description("状态")]
        public ExamStaus Status { get; set; } = ExamStaus.Normal;
    }
}
