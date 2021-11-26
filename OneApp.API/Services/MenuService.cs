using OneApp.Data;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public class MenuService : IMenuService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MenuService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Menu> CreateMenu(Menu newMenu)
        {
            await _unitOfWork.Menus.AddAsync(newMenu);
            await _unitOfWork.CommitAsync();

            return newMenu;
        }

        public async Task DeleteMenu(Menu menu)
        {
            _unitOfWork.Menus.Remove(menu);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Menu>> GetAllMenus()
        {
            return await _unitOfWork.Menus.GetAllAsync();
        }

        public async Task<Menu> GetMenuByCategory(Category category)
        {
            return await _unitOfWork.Menus.GetMenuByCategoryAsync(category);
        }

        public async Task<Menu> GetMenuById(int id)
        {
            return await _unitOfWork.Menus.GetMenuByIdAsync(id);
        }

        public async Task UpdateMenu(Menu menuToBeUpdated, Menu menu)
        {
            menuToBeUpdated.Category = menu.Category;
            menuToBeUpdated.Items = menu.Items;

            await _unitOfWork.CommitAsync();
        }
    }
}
