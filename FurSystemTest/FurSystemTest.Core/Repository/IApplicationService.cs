using FurSystemTest.Core.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Repository
{
    public interface IApplicationService
    {
        /// <summary>
        /// 根据ClientId获取应用信息
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public Applications GetApplication(string clientId);
    }
}
