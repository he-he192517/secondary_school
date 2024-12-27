using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Admission_System;

namespace FurSystemTest.Application.Services.Admission_System
{
    public class StudentService : IStudentService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;
        public async Task<List<Student>> GetStudentList()
        {
            return await _db.Queryable<Student>().ToListAsync();
        }
    }
}
