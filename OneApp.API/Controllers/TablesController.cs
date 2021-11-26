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
    public class TablesController : ControllerBase
    {
        
        private readonly ITableService _tableService;

        public TablesController(ITableService tableService)
        {
            _tableService = tableService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<Table>>> GetAllTables()
        {
            var tables = await _tableService.GetAllTables();

            return Ok(tables);
        }

        [HttpPost("")]
        public async Task<ActionResult<Table>> Createtables([FromBody] Table saveTable)
        {    
            var newtable = await _tableService.CreateTable(saveTable);

            return Ok(newtable);
        }
    }
}
