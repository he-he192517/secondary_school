using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class TeacherService : ITeacherService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public Teacher GetTeacherById(int teacherId)
        {
            return _db.Queryable<Teacher>().Where(c => c.TeacherId == teacherId).First();
        }
    }
}
