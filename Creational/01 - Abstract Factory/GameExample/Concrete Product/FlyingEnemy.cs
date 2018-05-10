using _01___Abstract_Factory.GameExample.Abstract_Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Abstract_Factory.GameExample.Concrete_Product
{
    public class FlyingEnemy : Player
    {
        public FlyingEnemy()
        {
            health = 10;
            attPow = 5;
        }

        public override void Attack()
        {
            Console.WriteLine("Flying Enemy attacked!");
        }

        public override void Move()
        {
            Console.WriteLine("Flying Enemy moved!");
        }
    }
}
