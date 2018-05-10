using _06___Flyweight.Publication.Flyweight_Base;

namespace _06___Flyweight.Publication.ConcreteFlyweight
{
    public class Book : IPublication
    {
        public Author Author { get; set; }
        public int PageCount { get; set; }
        public Publisher Publisher { get; set; }
        public string Title { get; set; }

        public Book(Author author, Publisher publisher, string title)
        {
            Author = author;
            Publisher = publisher;
            Title = title;
        }

        public Book(Author author, int pageCount, Publisher publisher, string title)
        {
            Author = author;
            PageCount = pageCount;
            Publisher = publisher;
            Title = title;
        }
    }
}
