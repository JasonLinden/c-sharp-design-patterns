using _01___Abstract_Factory.Auto.Abstract_Factory;
using _01___Abstract_Factory.Cars.Client;
using _01___Abstract_Factory.GameExample.Abstract_Factory;
using _01___Abstract_Factory.GameExample.Client;
using _01___Abstract_Factory.GameExample.Enums;
using System;

namespace _01___Abstract_Factory
{
    class Program
    {
        // The idea behind the abstract factory pattern is to delegate the creation of a family of objects 
        // to another class so that the client does not need to deal with that responsibility.

        // A family of objects can be books and publishers or motorbikes and scooters

        //Client
        //This is a class which use AbstractFactory and AbstractProduct interfaces to create a family of related objects.

        //AbstractFactory
        //This is an interface which is used to create abstract product

        //ConcreteFactory
        //This is a class which implements the AbstractFactory interface to create concrete products.

        //AbstractProduct
        //This is an interface which declares a type of product.

        //ConcreteProduct
        //This is a class which implements the AbstractProduct interface to create product.

        // First we need to create the abstract product and concrete products
        // Then we create the abstract factory and concrete factories.
        // And finally implement everything into the client.

        static void Main(string[] args)
        {
            // Not always necessary to create a producer/client.
            #region Game Example

            // Alternative to this would be to create a factory for flying and walking.
            NPCFactory enemyFactory = NPCFactoryProducer.Producer("EmenyFactory");
            var flyingEnemy = enemyFactory.GetEnemy(EnemyTypes.Flying);

            NPCFactory friendlyFactory = NPCFactoryProducer.Producer("FriendlyFactory");
            var walkingFriendly = friendlyFactory.GetFriendly(FriendlyTypes.Walking);

            flyingEnemy.Attack();
            walkingFriendly.Move();


            #endregion

            #region Car Example

            // Class can be configured in the config file or property settings.

            var fordFactory = CarProducer.ProduceFactory();
            var fordSedan = fordFactory.CreateSedan();
            var fordCoupe = fordFactory.CreateCoupe();

            #endregion

            #region Auto

            IAutoFactory fac = AutoFactory.ProduceFactory();

            var car = fac.CreateSportsCar();
            car.TurnOn();
            car.TurnOff();

            car = fac.CreateLuxuryCar();
            car.TurnOn();
            car.TurnOff();

            car = fac.CreateEconomyCar();
            car.TurnOn();
            car.TurnOff();

            #endregion

            Console.ReadKey();
        }
    }
}
