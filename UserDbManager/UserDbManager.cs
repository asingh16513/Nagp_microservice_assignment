using Domain.Models;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UserDbManager
{
    public class UserDbManager : IUser
    {
        public async Task<User> GetUserById(int id)
        {
            using (var context = new UserDbContext())
            {
                var user = await context.Users.FirstOrDefaultAsync(p => p.Id == id);
                return user;
            }
        }

        public async Task<int> AddUser(User user)
        {
            using (var context = new UserDbContext())
            {
                context.Users.Add(user);
                return await context.SaveChangesAsync();

            }
        }

        public async Task<List<User>> GetUsers()
        {
            using (var context = new UserDbContext())
            {
                var users = await context.Users.ToListAsync();
                return users;
            }
        }
    }
}
