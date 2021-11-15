using OneApp.Data.Repositories;
using System;
using System.Threading.Tasks;

namespace OneApp.Data
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        Task<int> CommitAsync();
    }
}
