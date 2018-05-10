using _01___Abstract_Factory.GameExample.Abstract_Factory;
using _01___Abstract_Factory.GameExample.Concrete_Factory;

namespace _01___Abstract_Factory.GameExample.Client
{
    public class NPCFactoryProducer
    {
        public static NPCFactory Producer(string factory)
        {
            switch (factory)
            {
                case ("EmenyFactory"):
                    return new EnemyFactory();
                case ("FriendlyFactory"):
                    return new FriendlyFactory();
                default:
                    break;
            }

            return null;
        }
    }
}
