using RobotStategy.Strategy;
using System;

namespace RobotStategy.ConcreteStrategy
{
    public class BorgBehaviour : IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tBorg Behaviour: if find another robot, assimilate it");
        }
    }
}
