using PosRest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OneApp.Data.Repositories
{
    public interface IUserRepo : IRepository<User>
    {       
        Task<User> GetUserByIdAsync(int id);
        Task<User> GetUserByNameAsync(string name);
    }
}
