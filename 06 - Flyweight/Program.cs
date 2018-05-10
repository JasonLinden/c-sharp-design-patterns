using _06___Flyweight.Publication;
using _06___Flyweight.Publication.FlyweightFactory;
using System;

namespace _06___Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }

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
    }
}
