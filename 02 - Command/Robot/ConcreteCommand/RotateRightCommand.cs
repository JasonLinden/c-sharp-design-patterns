using _02___Command.Robot.Command;
using _02___Command.Robot.Receiver;

namespace _02___Command.Robot.ConcreteCommand
{
    public class RotateRightCommand : RobotCommandBase
    {
        public double RightRotationAngle { get; set; }

        public RotateRightCommand(RobotObject robot) : base(robot) { }

        public override void Execute()
        {
            _robot.RotateRight(RightRotationAngle);
        }

        public override void Undo()
        {
            _robot.RotateLeft(RightRotationAngle);
        }
    }
}
