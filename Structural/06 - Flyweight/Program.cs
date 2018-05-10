using _06___Flyweight.Publication;
using _06___Flyweight.Publication.FlyweightFactory;
using _06___Flyweight.Restaurant.Flyweight;
using _06___Flyweight.Restaurant.FlyweightFactory;
using System;

namespace _06___Flyweight
{
    class Program
    {
        // Note that the ConcreteFlyweight classes are, of course, very similar to one another:
        // they all have the same properties.This is critical to using Flyweight: all of the related objects must have 
        // the same definition(or at least reasonably close to the same definition).

        static void Main(string[] args)
        {
            #region Publication

            // Keen observers will probably already notice the problem: 
            // The Author value we’re passing into our tuple creation is always a new Author() 
            // instance in this example. Even though the string Name property value of the Author is the same in both cases, 
            // the underlying Author object is different, and therefore, the generated key that is used for comparison 
            // within the Library.GetPublication() method differs.

            // The solution is to explicitly pass the same instance of Author to both our Book retrieval attempts,
            // which we do here in Example2():
            Example1();
            Example2();
            Example3();

            #endregion

            #region Sliders 

            // The Slider class has properties for Name, Cheese, Toppings, and Price 
            // (all of which are part of the intrinsic state of these objects)

            // Build a slider order using patron's input
            Console.WriteLine("Please enter your slider order (use characters B, V, Z with no spaces):");
            var order = Console.ReadLine();
            char[] chars = order.ToCharArray();

            SliderFactory factory = new SliderFactory();

            int orderTotal = 0;

            //Get the slider from the factory
            foreach (char c in chars)
            {
                orderTotal++;
                Slider character = factory.GetSlider(c);
                character.Display(orderTotal);
            }

            // Looking at the screenshot above, the FlyweightFactory will have only created new sliders for orders 1, 3, and 4, 
            // with every other order being a copy of those objects.This is the power of Flyweight: 
            // you can theoretically improve performance by only instantiating new objects on first creation.

            Console.ReadKey();

            #endregion
        }

        #region Publication

        public static void Example1()
        {
            var library = new Library();
            var book = library.GetPublication(
            Tuple.Create(
                new Author("Patrick Rothfuss"),
                "The Name of the Wind",
                PublicationType.Book
                )
            );

            var graphicNovel = library.GetPublication(
            Tuple.Create(
                new Author("Julie Doucet"),
                "My New York Diary",
                PublicationType.GraphicNovel
                )
            );

            // Try retrieving Publication with same key.
            book = library.GetPublication(
                Tuple.Create(
                    new Author("Patrick Rothfuss"),
                    "The Name of the Wind",
                    PublicationType.Book
                    )
            );
        }

        public static void Example2()
        {
            // Create library.
            var library = new Library();

            // Create Author instances.
            var patrickRothfuss = new Author("Patrick Rothfuss");
            var julieDoucet = new Author("Julie Doucet");

            // Create or retrieve new book.
            var book = library.GetPublication(
                Tuple.Create(
                    patrickRothfuss,
                    "The Name of the Wind",
                    PublicationType.Book
                    )
                    );

            var graphicNovel = library.GetPublication(
                Tuple.Create(
                    julieDoucet,
                    "My New York Diary",
                    PublicationType.GraphicNovel
                    )
                    );

            // Try retrieving Publication with same key.
            book = library.GetPublication(
                Tuple.Create(
                    patrickRothfuss,
                    "The Name of the Wind",
                    PublicationType.Book
                    )
                    );
        }

        public static void Example3()
        {
            var library = new Library();

            // Try to retrieve a Publication with an invalid PublicationType.
            library.GetPublication(
                Tuple.Create(
                    new Author("Dante"),
                    "Divine Comedy",
                    PublicationType.Epic
                    ));
        } 

        #endregion
    }
}
