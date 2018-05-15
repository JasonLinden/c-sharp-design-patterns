using _04___Iterator.Books.Advanced.ConcreteAggregate;
using _04___Iterator.Books.Advanced.Iterator;
using System.Linq;

namespace _04___Iterator.Books.Advanced.ConcreteIterator
{
    /// <summary>
    /// Handles iteration logic for passed Aggregate.
    /// </summary>
    public class IteratorClass : IIterator
    {
        private readonly AggregateClass _aggregate;
        private int _index = -1;

        public IteratorClass(AggregateClass aggregate)
        {
            _aggregate = aggregate;
        }

        /// <summary>
        /// Get the Aggregate collection element of current index, otherwise null.
        /// </summary>
        public object Current => _index < _aggregate.Count ? _aggregate[_index] : null;

        /// <summary>
        /// Iterate the index count.
        /// </summary>
        /// <returns>Indicates if index is within bounds of collection indices.</returns>
        public bool Next()
        {
            _index++;
            return _index < _aggregate.Count;
        }
    }
}
