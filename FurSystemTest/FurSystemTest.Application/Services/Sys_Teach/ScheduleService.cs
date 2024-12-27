using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class ScheduleService : IScheduleService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public DailySchedule GetDailyScheduleById(int scheduleId)
        {
            return _db.Queryable<DailySchedule>().Where(c => c.ScheduleId == scheduleId).First();
        }
    }
}
