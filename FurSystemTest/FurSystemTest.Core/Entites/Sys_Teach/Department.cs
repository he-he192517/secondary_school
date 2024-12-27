using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    [SugarTable("departments")]
    public class Department
    {
        /// <summary>
        /// 部门ID
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int DepartmentId { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [SugarColumn(ColumnName = "DepartmentName")]
        public string DepartmentName { get; set; }

        /// <summary>
        /// 职责
        /// </summary>
        [SugarColumn(ColumnName = "Responsibilities")]
        public string Responsibilities { get; set; }  // 职责字段
    }
}
