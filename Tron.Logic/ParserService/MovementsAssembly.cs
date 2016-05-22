using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tron.Logic.Movements;

namespace Tron.Logic.ParserService
{
    public class MovementsAssembly
    {
        public static Dictionary<string, Type> Load()
        {
            var dictionary = new Dictionary<string, Type>();
            var q = GetTypes();
            foreach (var movementType in q.ToList())
            {
                var instance = (IMovement)Activator.CreateInstance(movementType);
                dictionary.Add(instance.GetIdentifier(), movementType);
            }
            return dictionary;
        }

        private static IEnumerable<Type> GetTypes()
        {
            const string movementNamespace = "Tron.Logic.Movements";
            return from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsClass && t.Namespace == movementNamespace
                select t;
        }
    }
}