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
    /// 学科表
    /// </summary>
    [SugarTable("subject")]
    public class Subject
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "SubjectID")]
        public int SubjectId { get; set; }

        /// <summary>
        /// 学科名称
        /// </summary>
        [SugarColumn(ColumnDataType = "varchar(100)", ColumnName = "SubjectName")]
        [Description("学科名称")]
        public string SubjectName { get; set; }

        /// <summary>
        /// 激活状态
        /// </summary>
        [SugarColumn(ColumnDataType = "tinyint", ColumnName = "IsActive")]
        [Description("激活状态")]
        public bool IsActive { get; set; } = true; // 默认值为1（激活）
    }
}
