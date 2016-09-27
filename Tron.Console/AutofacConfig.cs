using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;
using Tron.Logic.ParserService;
using Tron.Logic;
using System.IO;

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
            builder.RegisterType<GameHandler>().As<IGameHandler>();
            builder.RegisterType<Parser>().As<IParser>();
            builder.RegisterType<FileReader>().As<IReader>();
            builder.RegisterType<MovementFactory>().As<MovementFactory>();
            builder.RegisterType<StreamReader>().As<StreamReader>();
            builder.RegisterType<Tile>().As<ITile>();

            return builder.Build();
        }
    }
}
