using System;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Persistence
{
    public class UserSqliteRepo : IUserRepo
    {
        private FamilyContext ctx;
        public UserSqliteRepo()
        {
            ctx = new FamilyContext();
        }
        public async Task<User> RegisterNewUser(User user)
        {
           await ctx.Users.AddAsync(user);
           await ctx.SaveChangesAsync();

           return user;
        }

        public async Task<User> ValidateUser(string userName, string password)
        {
            User user = await ctx.Users.FirstAsync(c => c.Username == userName && c.Password == password);

            if (user != null)
            {
                return user;
            }

            throw new Exception("User not exist");
        }
    }
}