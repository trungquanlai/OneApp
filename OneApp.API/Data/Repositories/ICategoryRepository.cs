using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public interface ICategoryRepository : IRepository<Category>
    {       
        Task<Category> GetCategoryByIdAsync(int id);
        Task<Category> GetCategoryByNameAsync(int name);
    }
}
