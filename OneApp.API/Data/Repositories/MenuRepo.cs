using Microsoft.EntityFrameworkCore;
using PosRest.Data;
using PosRest.Models;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public class MenuRepo : Repository<Menu>, IMenuRepo
    { 
        private OneAppContext OneAppContext
        {
            get { return Context as OneAppContext; }
        }

        public MenuRepo(OneAppContext context) : base(context)
        { }

        public async Task<Menu> GetMenuByIdAsync(int id)
        {
            return await OneAppContext.Menus
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<Menu> GetMenuByCategoryAsync(Category category)
        {
            return await OneAppContext.Menus
                .SingleOrDefaultAsync(c => c.Category == category);
        }
    }
}
