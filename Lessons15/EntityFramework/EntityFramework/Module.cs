using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityFramework.Services;
using EntityFramework.Interfaces;
using EntityFramework.Models;

namespace EntityFramework
{
    public class Module:NinjectModule
    {
        public override void Load()
        {
            Bind<DbContext>().To<AppContext>().InSingletonScope();
            Bind<IRepo<Shop>>().To<ShopService>().InTransientScope();
        }
    }

}
