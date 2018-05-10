using _01___Abstract_Factory.GameExample.Abstract_Product;
using _01___Abstract_Factory.GameExample.Enums;

namespace _01___Abstract_Factory.GameExample.Abstract_Factory
{
    public abstract class NPCFactory
    {
        public abstract Player GetEnemy(EnemyTypes type);
        public abstract Player GetFriendly(FriendlyTypes type);
    }
}
