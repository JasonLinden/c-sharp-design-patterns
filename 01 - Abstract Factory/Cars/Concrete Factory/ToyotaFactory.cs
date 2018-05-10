using _01___Abstract_Factory.Cars.Abstract_Factory;
using _01___Abstract_Factory.Cars.Abstract_Product;
using _01___Abstract_Factory.Cars.Concrete_Product;

namespace _01___Abstract_Factory.Cars.Concrete_Factory
{
    public class ToyotaFactory : CarFactory
    {
        // Here we build the spcific objects

        public override Convertible CreateConvertible()
        {
            return new MR2();
        }

        public override Coupe CreateCoupe()
        {
            return new Corolla();
        }

        public override Sedan CreateSedan()
        {
            return new Camry();
        }
    }
}
