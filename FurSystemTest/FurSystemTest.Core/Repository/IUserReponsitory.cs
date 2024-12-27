using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Repository
{
    public interface IUserReponsitory
    {
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool CheckUser(string userName, string password);

        /// <summary>
        /// 根据用户名获取用户信息
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUser(string userName);

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        public Task<List<User>> GetAllUserAsync();
    }
}
