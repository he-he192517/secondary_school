using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using SqlSugar;

namespace FurSystemTest.Core.Repository
{
    public class UserRepository: IUserReponsitory, IDynamicApiController, ITransient
    {
        private static readonly ISqlSugarClient Db = DbContext.Instance;

        public bool CheckUser(string userName, string password)
        {
            return Db.Queryable<User>()
                      .Any(u => u.Account == userName && u.Password == password);
        }

        public User GetUser(string userName)
        {
            return Db.Queryable<User>()
                      .First(u => u.Account == userName);
        }

        public async Task<List<User>> GetAllUserAsync()
        {
            return await Db.Queryable<User>().ToListAsync();
        }
    }
}
