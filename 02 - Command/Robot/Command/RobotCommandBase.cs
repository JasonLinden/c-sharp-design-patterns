using _02___Command.Robot.Receiver;

namespace _02___Command.Robot.Command
{
    public abstract class RobotCommandBase
    {
        protected RobotObject _robot;

        public RobotCommandBase(RobotObject robot)
        {
            _robot = robot;
        }

        public abstract void Execute();

        public abstract void Undo();
    }
}
