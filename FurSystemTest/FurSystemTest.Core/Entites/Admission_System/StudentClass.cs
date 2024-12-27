using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Admission_System
{
    /// <summary>
    /// 学生班级关联表
    /// </summary>
    [SugarTable("StudentClasses")]
    public class StudentClass
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "StudentClassID")]
        public int StudentClassID { get; set; }

        /// <summary>
        /// 学生ID
        /// </summary>
        [SugarColumn(ColumnName = "StudentID")]
        public int? StudentID { get; set; }  // 允许为空，外键引用

        /// <summary>
        /// 班级ID
        /// </summary>
        [SugarColumn(ColumnName = "ClassID")]
        public int? ClassID { get; set; }  // 允许为空，外键引用

        /// <summary>
        /// 确认状态
        /// </summary>
        [SugarColumn(ColumnDataType = "bit", ColumnName = "IsConfirmed")]
        public bool IsConfirmed { get; set; } = false;
    }
}
