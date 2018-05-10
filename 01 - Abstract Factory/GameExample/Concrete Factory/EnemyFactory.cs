using _01___Abstract_Factory.GameExample.Abstract_Factory;
using _01___Abstract_Factory.GameExample.Abstract_Product;
using _01___Abstract_Factory.GameExample.Concrete_Product;
using _01___Abstract_Factory.GameExample.Enums;

namespace _01___Abstract_Factory.GameExample.Concrete_Factory
{
    class EnemyFactory : NPCFactory
    {
        public override Player GetEnemy(EnemyTypes type)
        {
            switch (type)
            {
                case EnemyTypes.Flying:
                    return new FlyingEnemy();
                case EnemyTypes.Walking:
                    return new WalkingEnemy();
                default:
                    break;
            }

            return null;
        }

        public override Player GetFriendly(FriendlyTypes type)
        {
            return null;
        }
    }
}
