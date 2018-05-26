using PostalService.Strategy;
using Strategy.PostalService;

namespace PostalService.ConcreteStrategy
{
    /// <summary>
    /// Strategy for oversized objects, such as furniture.
    /// 
    /// Uses large box, foam, and tape.
    /// </summary>
    internal class OversizedStrategy : PackagingStrategy
    {
        public override void Pack(Package package)
        {
            package.Packaging.Add(PackingMaterials.LargeBox);
            package.Packaging.Add(PackingMaterials.Foam);
            package.Packaging.Add(PackingMaterials.Tape);
        }
    }
}
