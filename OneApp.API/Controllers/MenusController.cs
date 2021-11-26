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
    public class MenuController : ControllerBase
    {
        
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Menu>>> GetAllMenus()
        {
            var menus = await _menuService.GetAllMenus();

            return Ok(menus);
        }

        [HttpPost("")]
        public async Task<ActionResult<Menu>> CreateMenu([FromBody] Menu saveMenu)
        {
            var newMenu = await _menuService.CreateMenu(saveMenu);

            return Ok(newMenu);
        }
    }
}
