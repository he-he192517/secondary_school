using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    /// <summary>
    /// 考试表
    /// </summary>
    [SugarTable("exams")]
    public class Exam
    {
        /// <summary>
        /// 考试ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int ExamId { get; set; }

        /// <summary>
        /// 考试名称
        /// </summary>
        [SugarColumn(ColumnName = "ExamName")]
        public string ExamName { get; set; }

        /// <summary>
        /// 考试班级
        /// </summary>
        [SugarColumn(ColumnName = "ExamClass")]
        public int ExamClass { get; set; }

        /// <summary>
        /// 考试时间
        /// </summary>
        [SugarColumn(ColumnName = "ExamDate")]
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// 学期ID
        /// </summary>
        [SugarColumn(ColumnName = "SemesterId")]
        public int SemesterId { get; set; }
    }
}
