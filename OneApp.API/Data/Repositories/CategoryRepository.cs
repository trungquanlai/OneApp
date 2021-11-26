using Microsoft.EntityFrameworkCore;
using PosRest.Data;
using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private OneAppContext OneAppContext
        {
            get { return Context as OneAppContext; }
        }

        public CategoryRepository(OneAppContext context) : base(context)
        { }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await OneAppContext.Categories
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<Category> GetCategoryByNameAsync(int name)
        {
            return await OneAppContext.Categories
                .SingleOrDefaultAsync(c => c.Name == name);
        }
    }
}
