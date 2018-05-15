using _04___Iterator.Books.Advanced.Iterator;

namespace _04___Iterator.Books.Advanced.Aggregate
{
    /// <summary>
    /// Defines members of Aggregate.
    /// </summary>
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
