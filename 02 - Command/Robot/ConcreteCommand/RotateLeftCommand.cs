using _02___Command.Robot.Command;
using _02___Command.Robot.Receiver;

namespace _02___Command.Robot.ConcreteCommand
{
    public class RotateLeftCommand : RobotCommandBase
    {
        public double LeftRotationAngle { get; set; }

        public RotateLeftCommand(RobotObject robot) : base(robot) { }

        public override void Execute()
        {
            _robot.RotateLeft(LeftRotationAngle);
        }

        public override void Undo()
        {
            _robot.RotateRight(LeftRotationAngle);
        }
    }
}
