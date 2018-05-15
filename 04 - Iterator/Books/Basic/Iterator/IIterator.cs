namespace _04___Iterator.Books.Advanced.Iterator
{
    /// <summary>
    /// Defines members of Iterator.
    /// </summary>
    public interface IIterator
    {
        object Current { get; }
        bool Next();
    }
}
