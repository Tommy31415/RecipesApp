using System.Threading.Tasks;
using RecipesApp.API.Models;

namespace RecipesApp.API.Data
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        Task<bool> UserExist(string username);
    }
}