using FurSystemTest.Core.Entites.Sys_Teach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public interface IDailyScheService
    {
        /// <summary>
        /// 获取作息时间表
        /// </summary>
        /// <returns></returns>
        public Task<List<DailySchedule>> GetDailySchedule();
    }
}
