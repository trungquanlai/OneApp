using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public interface IItemRepo : IRepository<Item>
    {
        Task<Item> GetItemByIdAsync(int id);
        Task<Item> GetItemByNameAsync(string name);
    }
}

