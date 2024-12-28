using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites.Sys_Teach
{
    [SugarTable("positions")]
    public class Position
    {
        /// <summary>
        /// 职务id
        /// </summary>
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
        public int PositionId { get; set; }

        /// <summary>
        /// 职务名称
        /// </summary>
        [SugarColumn(ColumnName = "PositionName")]
        public string PositionName { get; set; }


    }
}
