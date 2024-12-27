using System.Collections.Generic;
using System.Threading.Tasks;

namespace FurSystemTest.Core.Repository
{
    public interface IRoleReponsitory
    {
        /// <summary>
        /// 根据应用名称和用户名获取权限名称
        /// </summary>
        /// <param name="username"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public string GetRoleByUserName(string username, string clientId);

        /// <summary>
        /// 根据应用名称和用户id获取权限名称
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public string GetRoleNameByUserId(int userId, string clientId);

        /// <summary>
        /// 根据用户名获取所有权限
        /// </summary>
        /// <param name="clientId"></param>
        /// <returns></returns>
        public Task<List<Role>> GetAllRolesAsync(string clientId);
    }
}
