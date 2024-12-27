using FurSystemTest.Core.Entites.Sys_Teach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public interface ITeacherService
    {
        /// <summary>
        /// 根据教师ID获取教师信息
        /// </summary>
        /// <param name="teacherId"></param>
        /// <returns></returns>
        public Teacher GetTeacherById(int teacherId);
    }
}
