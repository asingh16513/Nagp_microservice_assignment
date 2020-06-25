using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UserDbManager;

namespace Core
{
    public static class InitializeDbService
    {
        public static IServiceCollection AddDbServiceConfigurations(IServiceCollection configuration)
        {
            UserDbContext userDb = new UserDbContext();
            userDb.Database.Migrate();
            return configuration;
        }
    }
}
