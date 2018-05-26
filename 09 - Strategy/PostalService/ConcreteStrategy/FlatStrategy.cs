using PostalService.Strategy;
using Strategy.PostalService;

namespace PostalService.ConcreteStrategy
{
    /// <summary>
    /// Strategy for flat objects, such as letters.
    /// 
    /// Uses envelope.
    /// </summary>
    internal class FlatStrategy : PackagingStrategy
    {
        public override void Pack(Package package)
        {
            package.Packaging.Add(PackingMaterials.Envelope);
        }
    }
}
