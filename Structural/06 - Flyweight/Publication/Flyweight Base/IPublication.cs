namespace _06___Flyweight.Publication.Flyweight_Base
{
    public interface IPublication
    {
        Author Author { get; set; }
        Publisher Publisher { get; set; }
        string Title { get; set; }
    }
}
