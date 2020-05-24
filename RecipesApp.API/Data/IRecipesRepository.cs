using System.Collections.Generic;
using System.Threading.Tasks;
using RecipesApp.API.Models;

namespace RecipesApp.API.Data
{
    public interface IRecipesRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}