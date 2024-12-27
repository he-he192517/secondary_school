using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Admission_System;

namespace FurSystemTest.Application.Services.Admission_System
{
    public class SchoolService : ISchoolService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public async Task<List<School>> GetSchoolListAsync()
        {
            return await _db.Queryable<School>().ToListAsync();
        }

        public async Task<bool> SaveOrUpdateSchoolAsync(School school)
        {
            return await _db.Storageable(school).DefaultAddElseUpdate().ExecuteCommandAsync() > 0;
        }

        public School GetSchoolById(int schoolId)
        {
            return _db.Queryable<School>().Where(it => it.SchoolID == schoolId).First();
        }

        public School GetSchoolByName(string name)
        {
            return _db.Queryable<School>().Where(it => it.SchoolName == name).First();
        }
    }
}
