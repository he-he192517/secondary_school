using FurSystemTest.Core.Entites.Admission_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Admission_System
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentList();
    }
}
