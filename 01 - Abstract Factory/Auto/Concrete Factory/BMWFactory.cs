using _01___Abstract_Factory.Auto.Abstract_Factory;
using _01___Abstract_Factory.Auto.Abstract_Product;
using System;

namespace _01___Abstract_Factory.Auto.Concrete_Factory
{
    public class BMWFactory : IAutoFactory
    {
        private BMWFactory() { }

        public IAutomobile CreateEconomyCar()
        {
            throw new NotImplementedException();
        }

        public IAutomobile CreateLuxuryCar()
        {
            throw new NotImplementedException();
        }

        public IAutomobile CreateSportsCar()
        {
            throw new NotImplementedException();
        }

        ~BMWFactory()
        {
            // Unload events
        }
    }
}
