using PostalService.Strategy;
using Strategy.PostalService;

namespace PostalService.ConcreteStrategy
{
    /// <summary>
    /// Strategy for pliable objects, such as clothing.
    /// 
    /// Uses envelope and tape.
    /// </summary>
    internal class PliableStrategy : PackagingStrategy
    {
        public override void Pack(Package package)
        {
            package.Packaging.Add(PackingMaterials.Envelope);
            package.Packaging.Add(PackingMaterials.Tape);
        }
    }
}
