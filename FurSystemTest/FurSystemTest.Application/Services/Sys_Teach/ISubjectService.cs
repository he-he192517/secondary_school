using FurSystemTest.Core.Entites.Sys_Teach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Application.Services.Sys_Teach
{
    public interface ISubjectService
    {
        /// <summary>
        /// 根据学科id获取学科信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Subject GetSubjectById(int id);
    }
}
