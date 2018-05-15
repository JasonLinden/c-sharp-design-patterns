using _04___Iterator.Books;
using _04___Iterator.Books.Advanced.ConcreteAggregate;
using _04___Iterator.Books.Advanced.ConcreteIterator;
using _04___Iterator.JellyBeans;
using _04___Iterator.JellyBeans.ConcreteAggregate;
using _04___Iterator.JellyBeans.ConcreteIterator;
using System;

namespace _04___Iterator
{
    class Program
    {
        static void Main()
        {
            BasicIteratorTest();

            AdvancedIteratorTest();

            #region Jelly Bean

            // Build a collection of jelly beans
            JellyBeanCollection collection = new JellyBeanCollection();
            collection[0] = new JellyBean("Cherry");
            collection[1] = new JellyBean("Bubble Gum");
            collection[2] = new JellyBean("Root Beer");
            collection[3] = new JellyBean("French Vanilla");
            collection[4] = new JellyBean("Licorice");
            collection[5] = new JellyBean("Buttered Popcorn");
            collection[6] = new JellyBean("Juicy Pear");
            collection[7] = new JellyBean("Cinnamon");
            collection[8] = new JellyBean("Coconut");

            // Create iterator
            var iterator = collection.CreateIterator();

            Console.WriteLine("Gimme all the jelly beans!");

            for (JellyBean item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.Flavor);
            }

            #endregion

            Console.ReadKey();
        }

        #region Book

        public static void BasicIteratorTest()
        {
            var aggregate = new AggregateClass();

            // Add Books to aggregate collection.
            aggregate.Add(new Book("The Hobbit", "J.R.R. Tolkien", 304));
            aggregate.Add(new Book("The Name of the Wind", "Patrick Rothfuss", 662));
            aggregate.Add(new Book("To Kill a Mockingbird", "Harper Lee", 281));
            aggregate.Add(new Book("1984", "George Orwell", 328));
            aggregate.Add(new Book("Jane Eyre", "Charlotte Brontë", 507));

            // Get new Iterator from aggregate.
            var iterator = aggregate.CreateIterator();
            // Loop while Next() element exists.
            while (iterator.Next())
            {
                // Output current object.
                Console.WriteLine(iterator.Current);
            }
        }

        public static void AdvancedIteratorTest()
        {
            // Create a new Advanced.Iterator<Book> collection.
            var collection = new Iterator<Book>
            {
                // Pass Books to Values property.
                Values = {
                    new Book("The Hobbit", "J.R.R. Tolkien", 304),
                    new Book("The Name of the Wind", "Patrick Rothfuss", 662),
                    new Book("To Kill a Mockingbird", "Harper Lee", 281),
                    new Book("1984", "George Orwell", 328) ,
                    new Book("Jane Eyre", "Charlotte Brontë", 507)
                }
            };

            // Iterate through collection and retrieve each Book.
            foreach (var book in collection)
            {
                // Output Book.
                Console.WriteLine(book);
            }
        } 

        #endregion
    }
}
