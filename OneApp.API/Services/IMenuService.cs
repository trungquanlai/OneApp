using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public interface IMenuService
    {
        Task<IEnumerable<Menu>> GetAllMenus();
        Task<Menu> GetMenuById(int id);
        Task<Menu> GetMenuByCategory(Category category);
        Task<Menu> CreateMenu(Menu newMenu);
        Task UpdateMenu(Menu menuToBeUpdated, Menu menu);
        Task DeleteMenu(Menu menu);
    }
}
