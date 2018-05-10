using _01___Abstract_Factory.GameExample.Abstract_Product;
using System;

namespace _01___Abstract_Factory.GameExample.Concrete_Product
{
    class WalkingEnemy : Player
    {
        public WalkingEnemy()
        {
            health = 10;
            attPow = 5;
        }

        public override void Attack()
        {
            Console.WriteLine("Walking Enemy attacked!");
        }

        public override void Move()
        {
            Console.WriteLine("Walking Enemy moved!");
        }
    }
}
