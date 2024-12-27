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
    /// 教师信息表
    /// </summary>
    [SugarTable("teachers")]
    public class Teacher
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "TeacherID")]
        public int TeacherId { get; set; }

        /// <summary>
        /// 教师编号
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(50)", ColumnName = "TeacherCode")]
        [Description("教师编号")]
        public string TeacherCode { get; set; }

        /// <summary>
        /// 教师姓名
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(100)", ColumnName = "TeacherName")]
        [Description("教师姓名")]
        public string TeacherName { get; set; }

        /// <summary>
        /// 入编年份
        /// </summary>
        [SugarColumn(ColumnDataType = "int", ColumnName = "EntryYear")]
        [Description("入编年份")]
        public int EntryYear { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [SugarColumn(ColumnDataType = "tinyint", ColumnName = "IsActive")]
        [Description("激活状态")]
        public bool IsActive { get; set; } = true; // 默认值为1（激活）

        /// <summary>
        /// 职务
        /// </summary>
        [SugarColumn(ColumnName = "Position")]
        public PositionType Position { get; set; } // 职务字段

        /// <summary>
        /// 所在部门
        /// </summary>
        [SugarColumn(ColumnName = "DepartmentId")]
        [Description("所在部门")]
        public int DepartmentId { get; set; } // 外键，指向部门表
    }
}
