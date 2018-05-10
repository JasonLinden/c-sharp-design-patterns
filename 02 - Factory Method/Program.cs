using _02___Factory_Method.Auto.Abstract_Factory;
using _02___Factory_Method.Simple_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02___Factory_Method
{
    class Program
    {
        // The simple factory method has a big flaw where the factory knows about the 
        // concrete class being created, where as the abstract and factory method only know of the interfaces

            // The bmw and audi concrete creation could all be different, as so can use the factory method to 
            // centralize the creation so the client only knows about the factory and not the complex creation

        static void Main(string[] args)
        {
            #region Simple Factory

            var carName = args[0];

            SimpleAutoFactory factory = new SimpleAutoFactory();

            IAuto car = factory.CreateInstance(carName);

            car.TurnOn();
            car.TurnOff();

            #endregion

            #region Factory Method

            IAutoFactory autoFactory = LoadFactory();

            IAuto autoCar = autoFactory.CreateAuto();

            car.TurnOn();
            car.TurnOff();

            #endregion
        }

        private static IAutoFactory LoadFactory()
        {
            var factoryName = Properties.Settings.Default.AutoFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IAutoFactory;
        }
    }
}
