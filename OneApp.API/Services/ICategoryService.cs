using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<Category> GetCategoryByName(int name);
        Task<Category> CreateCategory(Category newCategory);
        Task UpdateCategory(Category categoryToBeUpdated, Category category);
        Task DeleteCategory(Category music);
    }
}
