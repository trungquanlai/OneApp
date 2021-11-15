using OneApp.Data;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Category> CreateCategory(Category newCategory)
        {
            await _unitOfWork.Categories.AddAsync(newCategory);
            await _unitOfWork.CommitAsync();

            return newCategory;
        }

        public async Task DeleteCategory(Category music)
        {
            _unitOfWork.Categories.Remove(music);

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.Categories.GetCategoryByIdAsync(id);
        }

        public async Task<Category> GetCategoryByName(int name)
        {
            return await _unitOfWork.Categories.GetCategoryByNameAsync(name);
        }

        public async Task UpdateCategory(Category categoryToBeUpdated, Category category)
        {
            categoryToBeUpdated.Name = category.Name;

            await _unitOfWork.CommitAsync();
        }
    }
}
