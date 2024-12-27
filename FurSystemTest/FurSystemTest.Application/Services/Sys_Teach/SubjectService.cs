using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public class SubjectService : ISubjectService, IDynamicApiController, ITransient
    {
        private readonly ISqlSugarClient _db = DbContext.Instance;

        public Subject GetSubjectById(int id)
        {
            return _db.Queryable<Subject>().Where(s => s.SubjectId == id).First();
        }
    }
}
