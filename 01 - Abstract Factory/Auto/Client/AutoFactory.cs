using _01___Abstract_Factory.Auto.Abstract_Factory;
using _01___Abstract_Factory.Cars.Abstract_Factory;
using System.Reflection;

namespace _01___Abstract_Factory.Cars.Client
{
    public class AutoFactory
    {
        public static IAutoFactory ProduceFactory()
        {
            // Here we can implement Unity and inject a class.
            return GetFactory("Cars.Concrete Factory.FordFactory");
        }

        static IAutoFactory GetFactory(string factoryName)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
