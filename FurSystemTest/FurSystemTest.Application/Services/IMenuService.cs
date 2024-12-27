using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites;

namespace FurSystemTest.Application.Services
{
    public interface IMenuService
    {
        /// <summary>
        /// 获取全部菜单列表
        /// </summary>
        /// <returns></returns>
        public Task<List<MenuEntity>> GetMenuListAsync(string clientId);

        /// <summary>
        /// 保存菜单（新增/更新）
        /// </summary>
        /// <param name="menu"></param>
        /// <returns></returns>
        public Task<bool> SaveMenuAsync(MenuEntity menu);

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="meuns"></param>
        /// <returns></returns>
        public Task<bool> DeleteMenuAsync(IEnumerable<MenuEntity> meuns);
    }
}
