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
    /// 班级信息表
    /// </summary>
    [SugarTable("class")]
    public class Class
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "ClassID")]
        public int ClassId { get; set; }

        /// <summary>
        /// 班级名称
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(100)", ColumnName = "ClassName")]
        [Description("班级名称")]
        public string ClassName { get; set; }

        /// <summary>
        /// 班主任教师ID
        /// </summary>
        [SugarColumn(ColumnName = "HomeroomTeacherID")]
        [Description("班主任教师ID")]
        public int? HomeroomTeacherId { get; set; } // 可为空

        /// <summary>
        /// 班级状态
        /// </summary>
        [SugarColumn(ColumnDataType = "enum", ColumnName = "ClassStatus")]
        [Description("班级状态")]
        public ClassStatusEnum ClassStatus { get; set; }

        /// <summary>
        /// 年级
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(50)", ColumnName = "Grade")]
        [Description("年级")]
        public string Grade { get; set; }

        // 可根据需求定义枚举
        public enum ClassStatusEnum
        {
            激活,
            停用
        }
    }
}
