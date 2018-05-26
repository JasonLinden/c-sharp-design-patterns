using PostalService.Strategy;
using Strategy.PostalService;

namespace PostalService.ConcreteStrategy
{
    /// <summary>
    /// Strategy for perishables, such as food.
    /// 
    /// Uses box, dry ice, foam, and tape.
    /// </summary>
    internal class PerishableStrategy : PackagingStrategy
    {
        public override void Pack(Package package)
        {
            package.Packaging.Add(PackingMaterials.Box);
            package.Packaging.Add(PackingMaterials.DryIce);
            package.Packaging.Add(PackingMaterials.Foam);
            package.Packaging.Add(PackingMaterials.Tape);
        }
    }
}
