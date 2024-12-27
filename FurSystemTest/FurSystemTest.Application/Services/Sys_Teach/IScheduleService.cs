using FurSystemTest.Core.Entites.Sys_Teach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public interface IScheduleService
    {
        /// <summary>
        /// 根据id获取日程信息
        /// </summary>
        /// <param name="scheduleId"></param>
        /// <returns></returns>
        public DailySchedule GetDailyScheduleById(int scheduleId);
    }
}
