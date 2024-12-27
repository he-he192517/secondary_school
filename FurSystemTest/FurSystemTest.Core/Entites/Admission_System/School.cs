using SqlSugar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Enum.Admission_System;
using System.ComponentModel.DataAnnotations;

namespace FurSystemTest.Core.Entites.Admission_System
{
    /// <summary>
    /// 学校表
    /// </summary>
    [SugarTable("Schools")]
    public class School
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "SchoolID")]
        public int SchoolID { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [Description("学校名称")]
        [SugarColumn(ColumnDataType = "nvarchar(255)", ColumnName = "SchoolName")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校类型（高中、初中、混合）
        /// </summary>
        [Description("学校类型")]
        [SugarColumn(ColumnDataType = "int", ColumnName = "SchoolType")]
        [Required(ErrorMessage = "请选择")]
        public SchoolTypeEnum? SchoolType { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [Description("联系电话")]
        [SugarColumn(ColumnDataType = "nvarchar(20)", ColumnName = "ContactNumber")]
        public string ContactNumber { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Description("地址")]
        [SugarColumn(ColumnDataType = "nvarchar(255)", ColumnName = "Address")]
        public string Address { get; set; }
    }
}
