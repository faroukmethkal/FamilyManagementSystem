using System.Threading.Tasks;
using Entitiy;

namespace Blazor.Data
{
    public interface IUserApi
    {
        Task<User> RegisterNewUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}