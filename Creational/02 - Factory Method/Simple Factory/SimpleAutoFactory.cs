using System;
using System.Collections.Generic;
using System.Reflection;

namespace _02___Factory_Method.Simple_Factory
{
    public class SimpleAutoFactory
    {
        Dictionary<string, Type> autos;

        public SimpleAutoFactory()
        {
            LoadTypesOfObjects();
        }

        private void LoadTypesOfObjects()
        {
            autos = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (var item in typesInThisAssembly)
            {
                if (item.GetInterface(typeof(IAuto).ToString()) != null)
                {
                    autos.Add(item.Name.ToLower(), item);
                }
            }
        }

        internal IAuto CreateInstance(string car)
        {
            Type t = GetTypeToCreate(car);

            if (t == null)
                return null;

            return Activator.CreateInstance(t) as IAuto;
        }

        private Type GetTypeToCreate(string car)
        {
            foreach (var item in autos)
            {
                if (item.Key.Contains(car))
                {
                    return autos[item.Key];
                }
            }

            return null;
        }
    }
}
