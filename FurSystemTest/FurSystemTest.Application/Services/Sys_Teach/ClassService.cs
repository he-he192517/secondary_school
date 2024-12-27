using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class ClassService : IClassService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;
        public Class GetClassById(int classId)
        {
            return _db.Queryable<Class>().Where(c => c.ClassId == classId).First();
        }
    }
}
