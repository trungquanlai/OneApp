using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Services
{
    public interface ITableService
    {
        Task<IEnumerable<Table>> GetAllTables();
        Task<Table> GetTableById(int id);
        Task<Table> GetTableByName(string name);
        Task<Table> CreateTable(Table newTable);
        Task UpdateTable(Table tableToBeUpdated, Table category);
        Task DeleteTable(Table table);
    }
}
