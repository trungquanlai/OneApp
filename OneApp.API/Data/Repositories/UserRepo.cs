using Microsoft.EntityFrameworkCore;
using PosRest.Data;
using PosRest.Models;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public class UserRepo : Repository<User>, IUserRepo
    { 
        private OneAppContext OneAppContext
        {
            get { return Context as OneAppContext; }
        }

        public UserRepo(OneAppContext context) : base(context)
        { }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await OneAppContext.Users
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<User> GetUserByNameAsync(string name)
        {
            return await OneAppContext.Users
                .SingleOrDefaultAsync(c => c.Name == name);
        }
    }
}
