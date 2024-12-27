using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    /// <summary>
    /// 学期表
    /// </summary>
    [SugarTable("semesters")]
    public class Semester
    {
        /// <summary>
        /// 学期ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int SemesterId { get; set; }

        /// <summary>
        /// 学期名称
        /// </summary>
        [SugarColumn(ColumnName = "SemesterName")]
        public string SemesterName { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [SugarColumn(ColumnName = "StartDate")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [SugarColumn(ColumnName = "EndDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 是否为当前学期
        /// </summary>
        [SugarColumn(ColumnName = "IsActive", DefaultValue = "1")]
        public bool IsActive { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [SugarColumn(ColumnName = "Description")]
        public string Description { get; set; }
    }
}
