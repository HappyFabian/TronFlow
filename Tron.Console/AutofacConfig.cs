using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Console
{
    public class AutofacConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TronApplication>().As<IApplication>();
            builder.RegisterType<ConsoleRenderer>().As<IRenderer>();
            builder.RegisterType<Game>().As<IGame>();
            builder.RegisterType<Tile>().As<ITile>();

            return builder.Build();
        }
    }
}
