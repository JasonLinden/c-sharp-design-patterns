using _01___Abstract_Factory.GameExample.Abstract_Factory;
using _01___Abstract_Factory.GameExample.Abstract_Product;
using _01___Abstract_Factory.GameExample.Concrete_Product;
using _01___Abstract_Factory.GameExample.Enums;

namespace _01___Abstract_Factory.GameExample.Concrete_Factory
{
    public class FriendlyFactory : NPCFactory
    {
        public override Player GetEnemy(EnemyTypes type)
        {
            return null;
        }

        public override Player GetFriendly(FriendlyTypes type)
        {
            switch (type)
            {
                case FriendlyTypes.Flying:
                    return new FlyingFriendly();
                case FriendlyTypes.Walking:
                    return new WalkingFriendly();
                default:
                    break;
            }

            return null;
        }
    }
}
