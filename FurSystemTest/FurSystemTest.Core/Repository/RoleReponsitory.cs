using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using FurSystemTest.Core.Entites;
using SqlSugar;

namespace FurSystemTest.Core.Repository
{
    public class RoleReponsitory : IRoleReponsitory, IDynamicApiController, ITransient
    {
        protected static readonly ISqlSugarClient Db = DbContext.Instance;

        public string GetRoleByUserName(string username, string clientId)
        {
            var result = Db.Queryable<User, UserRole, Role, ApplicationRole, Applications>(
                    (u, ur, r, ar, a) => new object[] {
                        JoinType.Inner, u.UserId == ur.UserId,
                        JoinType.Inner, ur.RoleId == r.RoleId,
                        JoinType.Inner, r.RoleId == ar.RoleId,
                        JoinType.Inner, ar.ApplicationId == a.ApplicationId
                    })
                .Where((u, ur, r, ar, a) => u.Account == username && a.ClientId == clientId)
                .Select((u, ur, r, ar, a) => r.Name)
                .First();

            return result;
        }

        public string GetRoleNameByUserId(int userId, string clientId)
        {
            var result = Db.Queryable<User, UserRole, Role, ApplicationRole, Applications>(
                (u, ur, r, ar, a) => new object[]
                {
                    JoinType.Inner, u.UserId == ur.UserId,
                    JoinType.Inner, ur.RoleId == r.RoleId,
                    JoinType.Inner, r.RoleId == ar.RoleId,
                    JoinType.Inner, ar.ApplicationId == a.ApplicationId
                })
                .Where((u, ur, r, ar, a) => u.UserId == userId && a.ClientId == clientId)
                .Select((u, ur, r, ar, a) => r.Remark)
                .First();
            return result;
        }

        public async Task<List<Role>> GetAllRolesAsync(string clientId)
        {
            var result = await Db.Queryable<Role, ApplicationRole, Applications>(
                    (r, ar, a) => new object[]
                    {
                        JoinType.Inner, r.RoleId == ar.RoleId,
                        JoinType.Inner, ar.ApplicationId == a.ApplicationId
                    })
                .Where((r, ar, a) => a.ClientId == clientId)
                .Select((r, ar, a) => r)
                .ToListAsync();
            return result;
        }
    }
}
