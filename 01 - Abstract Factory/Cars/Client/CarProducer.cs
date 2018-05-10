using _01___Abstract_Factory.Cars.Abstract_Factory;
using System.Reflection;

namespace _01___Abstract_Factory.Cars.Client
{
    public class CarProducer
    {
        public static CarFactory ProduceFactory()
        {
            return GetFactory("Cars.Concrete Factory.FordFactory");
        }

        static CarFactory GetFactory(string factoryName)
        {
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as CarFactory;
        }
    }
}
