using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Console
{
    public class AutofacConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TronApplication>().As<IApplication>();
            builder.RegisterType<ConsoleRenderer>().As<IRenderer>();

            return builder.Build();
        }
    }
}
