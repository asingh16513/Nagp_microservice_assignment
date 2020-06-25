using Domain.Models;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Core
{
    public sealed class UserManager
    {
        private static UserManager instance = null;
        private static readonly object padlock = new object();

        private IUser _userRepository { get; set; }
        private UserManager(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        public static UserManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new UserManager(GetInstance.Get<IUser>());
                    }
                    return instance;
                }
            }
        }
        public async Task<int> AddUser(User user)
        {
            return await _userRepository.AddUser(user);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }
    }
}
