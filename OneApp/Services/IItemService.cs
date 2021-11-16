using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public interface IItemService
    {
        Task<IEnumerable<Item>> GetAllItems();
        Task<Item> GetItemById(int id);
        Task<Item> GetItemByName(string name);
        Task<Item> CreateItem(Item newItem);
        Task UpdateItem(Item itemToBeUpdated, Item item);
        Task DeleteItem(Item item);
    }
}
