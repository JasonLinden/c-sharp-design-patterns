using _04___Iterator.JellyBeans.Aggregate;
using _04___Iterator.JellyBeans.ConcreteIterator;
using _04___Iterator.JellyBeans.Iterator;
using System.Collections;

namespace _04___Iterator.JellyBeans.ConcreteAggregate
{
    /// <summary>
    /// The ConcreteAggregate class
    /// </summary>
    class JellyBeanCollection : ICandyCollection
    {
        private ArrayList _items = new ArrayList();

        public IJellyBeanIterator CreateIterator()
        {
            return new JellyBeanIterator(this);
        }

        // Gets jelly bean count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}
