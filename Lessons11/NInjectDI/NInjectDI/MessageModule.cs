using Ninject.Modules;
using NInjectDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI
{
    internal class MessageModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IDateTimeGenerator>().To<DataTimeGenerator>();
            this.Bind<IGreetingsGenerator>().To<GreetingsGenerator>();
            this.Bind<INamesGenerator>().To<NamesGenerator>(); 
        }
    }
}
