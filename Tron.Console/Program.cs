using Autofac;
using System;
using Tron.Console;

namespace Tron.ConsoleImplementation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = AutofacConfig.Configure();
            using (var scope = container.BeginLifetimeScope())
            {
                var game = scope.Resolve<IApplication>();
                game.Run();
            }
        }
    }
}
