using _01___Abstract_Factory.GameExample.Abstract_Product;
using System;

namespace _01___Abstract_Factory.GameExample.Concrete_Product
{
    class WalkingFriendly : Player
    {
        public WalkingFriendly()
        {
            health = 10;
            attPow = 5;
        }

        public override void Attack()
        {
            Console.WriteLine("Walking Friendly attacked!");
        }

        public override void Move()
        {
            Console.WriteLine("Walking Friendly moved!");
        }
    }
}
