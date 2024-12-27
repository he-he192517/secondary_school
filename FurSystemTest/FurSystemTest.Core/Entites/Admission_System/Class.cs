using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Enum.Admission_System;

namespace FurSystemTest.Core.Entites.Admission_System
{
    /// <summary>
    /// 班级表
    /// </summary>
    [SugarTable("Classes")]
    public class Class
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ClassID")]
        public int ClassID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(100)", ColumnName = "ClassName")]
        public string ClassName { get; set; }

        /// <summary>
        /// 学校ID
        /// </summary>
        [SugarColumn(ColumnName = "SchoolID")]
        public int? SchoolID { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [SugarColumn(ColumnDataType = "int", ColumnName = "GradeName")]
        public Grade GradeName { get; set; }
    }
}
