using Furion.DependencyInjection;
using Furion.DynamicApiController;
using FurSystemTest.Core.Entites;
using SqlSugar;

namespace FurSystemTest.Core.Repository
{
    /// <summary>
    /// 应用表数据库仓储
    /// </summary>
    public class ApplicationService : IApplicationService, IDynamicApiController, ITransient
    {
        /// <summary>
        /// 依赖注入
        /// </summary>
        private static readonly ISqlSugarClient Db = DbContext.Instance;

        public Applications GetApplication(string clientId)
        {
            return Db.Queryable<Applications>().Where(a => a.ClientId == clientId).First();
        }
    }
}
