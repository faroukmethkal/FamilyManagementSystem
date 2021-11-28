using System.Threading.Tasks;
using Entitiy;

namespace Domain.Data
{
    public interface IUserRepo
    {
        Task<User> RegisterNewUser(User user);
        Task<User> ValidateUser(string userName, string password);
    }
}