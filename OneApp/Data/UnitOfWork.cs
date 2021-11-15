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

        public UnitOfWork(OneAppContext context)
        {
            _context = context;
        }

        public ICategoryRepository Categories => _categoryRepo ?? new CategoryRepository(_context);

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
