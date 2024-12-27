using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurSystemTest.Core.Entites;

namespace FurSystemTest.Application.Services;

public class MenuService : IMenuService, IDynamicApiController, ITransient
{
    private readonly ISqlSugarClient _db = DbContext.Instance;

    public async Task<List<MenuEntity>> GetMenuListAsync(string clientId)
    {
        return await _db.Queryable<MenuEntity>().Where(x => x.ClientId == clientId).ToListAsync();
    }

    public async Task<bool> SaveMenuAsync(MenuEntity menu)
    {
        return await _db.Storageable(menu).DefaultAddElseUpdate().ExecuteCommandAsync() > 0;
    }

    public async Task<bool> DeleteMenuAsync(IEnumerable<MenuEntity> meuns)
    {
        return await _db.Deleteable<MenuEntity>(meuns).ExecuteCommandAsync() > 0;
    }
}

