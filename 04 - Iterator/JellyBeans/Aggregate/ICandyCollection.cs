using _04___Iterator.JellyBeans.Iterator;

namespace _04___Iterator.JellyBeans.Aggregate
{
    /// <summary>
    /// The aggregate interface
    /// </summary>
    interface ICandyCollection
    {
        IJellyBeanIterator CreateIterator();
    }
}
