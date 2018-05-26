using RobotStategy.Strategy;
using System;

namespace RobotStategy.ConcreteStrategy
{
    class AggresiveBehaviour : IRobotBehaviour
    {
        public void Move()
        {
            Console.WriteLine("\tAggresive Behaviour: if find another robot, attack it");
        }
    }
}
