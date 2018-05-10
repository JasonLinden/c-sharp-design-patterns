using _06___Flyweight.Publication.Flyweight_Base;

namespace _06___Flyweight.Publication.ConcreteFlyweight
{
    public class GraphicNovel : IPublication
    {
        public Author Author { get; set; }
        public Illustrator Illustrator { get; set; }
        public Publisher Publisher { get; set; }
        public string Title { get; set; }

        public GraphicNovel(Author author, Illustrator illustrator, Publisher publisher, string title)
        {
            Author = author;
            Illustrator = illustrator;
            Publisher = publisher;
            Title = title;
        }
    }
}
