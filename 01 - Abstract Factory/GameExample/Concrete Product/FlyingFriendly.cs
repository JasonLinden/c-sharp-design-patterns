using _01___Abstract_Factory.GameExample.Abstract_Product;
using System;

namespace _01___Abstract_Factory.GameExample.Concrete_Product
{
    class FlyingFriendly : Player
    {
        public FlyingFriendly()
        {
            health = 10;
            attPow = 5;
        }

        public override void Attack()
        {
            Console.WriteLine("Flying Friendly attacked!");
        }

        public override void Move()
        {
            Console.WriteLine("Flying Friendly moved!");
        }
    }
}
