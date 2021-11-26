using Microsoft.AspNetCore.Mvc;
using OneApp.Services;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {            
            _categoryService = categoryService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllCategories()
        {
            var categories = await _categoryService.GetAllCategories();

            return Ok(categories);
        }

        [HttpPost("")]
        public async Task<ActionResult<Category>> CreateCategory([FromBody] Category saveCategory)
        {    
            var newCategory = await _categoryService.CreateCategory(saveCategory);

            return Ok(newCategory);
        }
    }
}
