using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace FurSystemTest.Core.Entites
{
    /// <summary>
    /// 应用表
    /// </summary>
    [SugarTable("applications")]
    public class Applications
    {
        [SugarColumn(IsPrimaryKey = true, IsIdentity = true, ColumnName = "Id")]
        public int ApplicationId { get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(50)", ColumnName = "ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// 客户端密钥
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(256)", ColumnName = "ClientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(100)", ColumnName = "Domain")]
        public string Domain { get; set; }

    }
}
