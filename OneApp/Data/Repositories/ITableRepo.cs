using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public interface ITableRepo : IRepository<Table>
    {       
        Task<Table> GetTableByIdAsync(int id);
        Task<Table> GetTableByNameAsync(string name);
    }
}
