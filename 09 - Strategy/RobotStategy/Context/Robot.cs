using RobotStategy.Strategy;
using System;

namespace RobotStategy.Context
{
    public class Robot
    {
        private readonly IRobotBehaviour _behaviour;
        private readonly string _name;
        public Robot(string name, IRobotBehaviour behaviour)
        {
            _behaviour = behaviour;
            _name = name;
        }

        public void Move()
        {
            Console.WriteLine(_name);
            _behaviour.Move();
        }
    }
}
