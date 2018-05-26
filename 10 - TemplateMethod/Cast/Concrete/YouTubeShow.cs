using Cast.Abstract;
using TemplateMethod.Cast;

namespace Cast.Concrete
{
    internal class YouTubeShow : Show
    {
        public override void AssignBroadcastSlot()
        {
            // Assign a default BroadcastSlot, 
            // which ensures the show is always available.
            BroadcastSlot = new BroadcastSlot();
            System.Console.WriteLine($"{Name} is a {BroadcastSlot.Type} broadcast.");
        }

        public override void FindNetwork()
        {
            Network = "YouTube";
            System.Console.WriteLine($"Network ({Network}) found for {Name}.");
        }

        /// <summary>
        /// Create new YouTube show.
        /// </summary>
        /// <param name="name">Name of show.</param>
        public YouTubeShow(string name) : base(name)
        {
        }
    }
}
