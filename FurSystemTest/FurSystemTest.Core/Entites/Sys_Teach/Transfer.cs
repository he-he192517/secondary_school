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
    /// 教师调动信息表
    /// </summary>
    [SugarTable("transfers")]
    public class Transfer
    {
        /// <summary>
        /// 调动ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        [Description("调动ID")]
        public int TransferId { get; set; }

        /// <summary>
        /// 教师ID
        /// </summary>
        [SugarColumn(ColumnName = "TeacherId")]
        [Description("教师ID")]
        public int TeacherId { get; set; }

        /// <summary>
        /// 原部门ID
        /// </summary>
        [SugarColumn(ColumnName = "FromDepartmentId")]
        [Description("原部门")]
        public int? FromDepartmentId { get; set; }  // 可空类型

        /// <summary>
        /// 目标部门ID
        /// </summary>
        [SugarColumn(ColumnName = "ToDepartmentId")]
        [Description("目标部门")]
        public int? ToDepartmentId { get; set; }  // 可空类型

        /// <summary>
        /// 调动日期
        /// </summary>
        [SugarColumn(ColumnName = "TransferDate")]
        [Description("调动日期")]
        public DateTime TransferDate { get; set; }

        /// <summary>
        /// 调动原因
        /// </summary>
        [SugarColumn(ColumnName = "Reason")]
        [Description("调动原因")]
        public string Reason { get; set; }

        /// <summary>
        /// 新职责
        /// </summary>
        [SugarColumn(ColumnName = "NewResponsibilities")]
        [Description("新职责")]
        public PositionType NewResponsibilities { get; set; }

        /// <summary>
        /// 原职责
        /// </summary>
        [SugarColumn(ColumnName = "OldResponsibilities")]
        [Description("原职责")]
        public PositionType OldResponsibilities { get; set; }

        /// <summary>
        /// 调动类型
        /// </summary>
        [SugarColumn(ColumnName = "TransferType")]
        [Description("调动类型")]
        public TransferType TransferType { get; set; }  // 使用枚举类型

        /// <summary>
        /// 状态
        /// </summary>
        [SugarColumn(ColumnName = "Status")]
        [Description("状态")]
        public TransferStatus Status { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [SugarColumn(ColumnName = "Notes")]
        [Description("备注")]
        public string Notes { get; set; }
    }
}
