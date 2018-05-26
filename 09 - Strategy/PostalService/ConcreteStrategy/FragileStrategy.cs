using PostalService.Strategy;
using Strategy.PostalService;

namespace PostalService.ConcreteStrategy
{
    /// <summary>
    /// Strategy for fragile objects, such as glassware.
    /// 
    /// Uses box, bubble wrap, foam, and tape.
    /// </summary>
    internal class FragileStrategy : PackagingStrategy
    {
        public override void Pack(Package package)
        {
            package.Packaging.Add(PackingMaterials.Box);
            package.Packaging.Add(PackingMaterials.BubbleWrap);
            package.Packaging.Add(PackingMaterials.Foam);
            package.Packaging.Add(PackingMaterials.Tape);
        }
    }
}
