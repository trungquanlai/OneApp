using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public interface IMenuRepo : IRepository<Menu>
    {       
        Task<Menu> GetMenuByIdAsync(int id);
        Task<Menu> GetMenuByCategoryAsync(Category category);
    }
}
