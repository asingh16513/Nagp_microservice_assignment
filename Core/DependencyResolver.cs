using Infrastructure;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Text;
using UserDbManager;

namespace Core
{
    public class DependencyResolver : NinjectModule
    {
        /// <summary>
        /// Function to load dependency.
        /// </summary>
        public override void Load()
        {
            Bind<IUser>().To<UserDbManager.UserDbManager>().InSingletonScope();
        }
    }
}
