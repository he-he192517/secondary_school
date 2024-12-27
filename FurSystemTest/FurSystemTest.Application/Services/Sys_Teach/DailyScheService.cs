using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class DailyScheService : IDailyScheService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public async Task<List<DailySchedule>> GetDailySchedule()
        {
            return await _db.Queryable<DailySchedule>().ToListAsync();
        }
    }
}
