using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Entites
{
    /// <summary>
    /// 应用表
    /// </summary>
    [SugarTable("applicationrole")]
    public class ApplicationRole
    {
        public int ApplicationId { get; set; }

        public int RoleId { get; set; }
    }
}
