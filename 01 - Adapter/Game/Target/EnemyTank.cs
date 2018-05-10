using System;

namespace _01___Adapter.Game.Target
{
    class EnemyTank : IEnemyAttacker
    {
        public void AssignDriver(string driverName)
        {
            Console.WriteLine("Enemy Tank assign driver " + driverName);
        }

        public void DriveForward()
        {
            Console.WriteLine("Enemy Tank drive forward");
        }

        public void FireWeapon()
        {
            Console.WriteLine("Enemy Tank fire weapon");
        }
    }
}
