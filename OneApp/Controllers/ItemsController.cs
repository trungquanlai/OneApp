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
    public class ItemsController : ControllerBase
    {
        
        private readonly IItemService _itemService;

        public ItemsController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Item>>> GetAllItems()
        {
            var items = await _itemService.GetAllItems();

            return Ok(items);
        }

        [HttpPost("")]
        public async Task<ActionResult<Item>> CreateItem([FromBody] Item saveItem)
        {    
            var newItem = await _itemService.CreateItem(saveItem);

            return Ok(newItem);
        }
    }
}
