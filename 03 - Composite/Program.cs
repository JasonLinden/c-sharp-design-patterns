using _03___Composite.Family.Composite;
using _03___Composite.Family.Leaf;
using _03___Composite.Soda.Composite;
using _03___Composite.Soda.Leaf;
using System;

namespace _03___Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Soda

            var colas = new Cola(210);
            colas.Flavours.Add(new VanillaCola(215));
            colas.Flavours.Add(new CherryCola(210));

            var lemonLime = new LemonLime(185);

            var rootBeers = new RootBeer(195);
            rootBeers.Flavours.Add(new VanillaRootBeer(200));
            rootBeers.Flavours.Add(new StrawberryRootBeer(200));

            SodaWater sodaWater = new SodaWater(180);
            sodaWater.Flavours.Add(colas);
            sodaWater.Flavours.Add(lemonLime);
            sodaWater.Flavours.Add(rootBeers);

            sodaWater.DisplayCalories(0);

            #endregion

            #region Family

            // Parent 1
            Person john = new Person("John");
            // Parent 2
            Person jane = new Person("Jane");

            // Child 1
            Person alice = new Person("Alice");
            // Child 2
            Person billy = new Person("Billy");
            // Child 3
            Person christine = new Person("Christine");

            // John and Jane are both parents of Alice
            john.AddChild(alice);
            jane.AddChild(alice);

            // John is also Billy's parent
            john.AddChild(billy);

            // Jane is also Christine's parent
            jane.AddChild(christine);

            // Since David is John's brother he is also an uncle.
            Uncle david = new Uncle("David");

            // David and John are both the children of their father Edward.
            Person edward = new Person("Edward");
            edward.AddChild(john);
            // Even though 'david' is class of Uncle it can still be added
            // as a child.
            edward.AddChild(david);

            #endregion

            Console.ReadKey();
        }
    }
}
