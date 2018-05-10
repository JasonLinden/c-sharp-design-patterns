using _01___Abstract_Factory.Cars.Abstract_Product;

namespace _01___Abstract_Factory.Cars.Abstract_Factory
{
    public abstract class CarFactory
    {
        public abstract Sedan CreateSedan();
        public abstract Convertible CreateConvertible();
        public abstract Coupe CreateCoupe();
    }
}
