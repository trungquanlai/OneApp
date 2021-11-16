using OneApp.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace OneApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        ITableRepo Tables { get; }
        IUserRepo Users { get; }
        IItemRepo Items { get; }
        IMenuRepo Menus { get; }
        Task<int> CommitAsync();
    }
}
