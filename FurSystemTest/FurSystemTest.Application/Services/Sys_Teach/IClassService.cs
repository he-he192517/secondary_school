using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Sys_Teach;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public interface IClassService
    {
        public Class GetClassById(int classId);
    }
}
