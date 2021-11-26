using OneApp.Data.Repositories;
using PosRest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly OneAppContext _context;
        private CategoryRepository _categoryRepo;
        private TableRepo _tableRepo;
        private UserRepo _userRepo;
        private ItemRepo _itemRepo;
        private MenuRepo _menuRepo;

        public UnitOfWork(OneAppContext context)
        {
            _context = context;
        }

        public ICategoryRepository Categories => _categoryRepo ?? new CategoryRepository(_context);

        public ITableRepo Tables => _tableRepo ?? new TableRepo(_context);

        public IUserRepo Users => _userRepo ?? new UserRepo(_context);

        public IItemRepo Items => _itemRepo ?? new ItemRepo(_context);

        public IMenuRepo Menus => _menuRepo ?? new MenuRepo(_context);

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
