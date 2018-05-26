using RobotStategy.Strategy;
using System;

namespace RobotStategy.ConcreteStrategy
{
    public class DefensiveBehaviour : IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tDefensive Behaviour: if find another robot, run from it");
        }
    }
}
