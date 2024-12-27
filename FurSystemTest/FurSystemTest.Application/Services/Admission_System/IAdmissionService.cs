using FurSystemTest.Core.Entites.Admission_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Admission_System
{
    public interface IAdmissionService
    {
        /// <summary>
        /// 获取录取信息
        /// </summary>
        /// <returns></returns>
        public Task<List<Admission>> GetAdmissionAsync();
    }
}
