using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites.Admission_System;

namespace FurSystemTest.Application.Services.Admission_System
{
    public interface ISchoolService
    {
        /// <summary>
        /// 获取学校列表
        /// </summary>
        /// <returns></returns>
        public Task<List<School>> GetSchoolListAsync();

        /// <summary>
        /// 新增或更新学校
        /// </summary>
        /// <param name="school"></param>
        /// <returns></returns>
        public Task<bool> SaveOrUpdateSchoolAsync(School school);

        /// <summary>
        /// 根据学校ID获取学校信息
        /// </summary>
        /// <param name="schoolId"></param>
        /// <returns></returns>
        public School GetSchoolById(int schoolId);

        /// <summary>
        /// 根据学校名称获取学校信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public School GetSchoolByName(string name);
    }
}
