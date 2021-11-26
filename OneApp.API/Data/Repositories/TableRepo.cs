using Microsoft.EntityFrameworkCore;
using PosRest.Data;
using PosRest.Models;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public class TableRepo : Repository<Table>, ITableRepo
    {
        private OneAppContext OneAppContext
        {
            get { return Context as OneAppContext; }
        }

        public TableRepo(OneAppContext context) : base(context)
        { }

        public async Task<Table> GetTableByIdAsync(int id)
        {
            return await OneAppContext.Tables
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<Table> GetTableByNameAsync(string name)
        {
            return await OneAppContext.Tables
                .SingleOrDefaultAsync(c => c.Name == name);
        }
    }
}
