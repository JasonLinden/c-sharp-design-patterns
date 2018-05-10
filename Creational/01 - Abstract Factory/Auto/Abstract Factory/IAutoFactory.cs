using _01___Abstract_Factory.Auto.Abstract_Product;

namespace _01___Abstract_Factory.Auto.Abstract_Factory
{
    public interface IAutoFactory
    {
        // Here we can add a param to determine which car to create.

        IAutomobile CreateEconomyCar();
        IAutomobile CreateSportsCar();
        IAutomobile CreateLuxuryCar();
    }
}
