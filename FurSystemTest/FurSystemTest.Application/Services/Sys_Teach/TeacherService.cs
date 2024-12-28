using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class TeacherService : ITeacherService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public async Task<bool> DeleteTeacherAsync(IEnumerable<Teacher> teachers)
        {
            return await _db.Deleteable<Teacher>(teachers).ExecuteCommandAsync() > 0;
        }

        public Teacher GetTeacherById(int teacherId)
        {
            return _db.Queryable<Teacher>().Where(c => c.TeacherId == teacherId).First();
        }

        public async Task<bool> SaveTeacherAsync(Teacher teacher)
        {
            return await _db.Storageable(teacher).DefaultAddElseUpdate().ExecuteCommandAsync() > 0;
        }
    }
}
