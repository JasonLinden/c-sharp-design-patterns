using _03___Builder.Pizza___Fluent.Builder;
using _03___Builder.Vehicle.Builder;
using _03___Builder.Vehicle.Concrete_Builder;
using _03___Builder.Vehicle.Director_Engineer;

namespace _03___Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ordinary Builder

            var shop = new VehicleClass();
            VehicleBuilder builder;

            builder = new ScooterBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show(); 

            #endregion

            #region Fluent Builder

            var pizzaPepOlives = new PizzaBuilder(Size.Medium)
                         .AddSauce()
                         .AddCheese(Cheese.Provolone)
                         .AddPepperoni()
                         .AddOlives()
                         .Build();

            var pizzaOlivesMushrooms = new PizzaBuilder()
                          .AddSauce()
                          .AddCheese()
                          .AddOlives()
                          .AddMushrooms()
                          .Build();

            #endregion
        }
    }
}
