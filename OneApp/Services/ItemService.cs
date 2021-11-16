using OneApp.Data;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public class ItemService : IItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Item> CreateItem(Item newItem)
        {
            await _unitOfWork.Items.AddAsync(newItem);
            await _unitOfWork.CommitAsync();

            return newItem;
        }

        public async Task DeleteItem(Item item)
        {
            _unitOfWork.Items.Remove(item);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Item>> GetAllItems()
        {
            return await _unitOfWork.Items.GetAllAsync();
        }

        public async Task<Item> GetItemById(int id)
        {
            return await _unitOfWork.Items.GetItemByIdAsync(id);
        }

        public async Task<Item> GetItemByName(string name)
        {
            return await _unitOfWork.Items.GetItemByNameAsync(name);
        }

        public async Task UpdateItem(Item itemToBeUpdated, Item item)
        {
            itemToBeUpdated.NameEN = item.NameEN;
            itemToBeUpdated.NameVN = item.NameVN;
            itemToBeUpdated.Description = item.Description;
            itemToBeUpdated.Price = item.Price;

            await _unitOfWork.CommitAsync();
        }
    }
}
