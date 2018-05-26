using RobotStategy.Strategy;
using System;

namespace RobotStategy.ConcreteStrategy
{
    public class NormalBehaviour : IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tNormal Behaviour: if find another robot, ignore it");
        }
    }
}
