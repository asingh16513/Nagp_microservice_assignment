using Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infrastructure
{
    public interface IUser
    {
        Task<List<User>> GetUsers();
        Task<User> GetUserById(int id);

        Task<int> AddUser(User user);
    }
}
