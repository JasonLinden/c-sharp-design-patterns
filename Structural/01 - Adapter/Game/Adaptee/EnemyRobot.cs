using System;

namespace _01___Adapter.Game.Adaptee
{
    public class EnemyRobot
    {
        public void CrushDriver(string driverName)
        {
            Console.WriteLine("Enemy Robot Crush Driver " + driverName);
        }

        public void WalkForward()
        {
            Console.WriteLine("Enemy Robot walk forward");
        }

        public void SmashWithHands()
        {
            Console.WriteLine("Enemy Robot Smash With Hands");
        }
    }
}
