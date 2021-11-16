using Microsoft.EntityFrameworkCore;
using PosRest.Data;
using PosRest.Models;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public class ItemRepo : Repository<Item>, IItemRepo
    {
        private OneAppContext OneAppContext
        {
            get { return Context as OneAppContext; }
        }

        public ItemRepo(OneAppContext context) : base(context)
        { }

        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await OneAppContext.Items
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<Item> GetItemByNameAsync(string name)
        {
            return await OneAppContext.Items
                .SingleOrDefaultAsync(c => c.NameEN == name || c.NameVN == name);
        }
    }
}
