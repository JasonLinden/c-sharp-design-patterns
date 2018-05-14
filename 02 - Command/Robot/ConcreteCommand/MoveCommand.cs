using _02___Command.Robot.Command;
using _02___Command.Robot.Receiver;

namespace _02___Command.Robot.ConcreteCommand
{
    public class MoveCommand : RobotCommandBase
    {
        public int ForwardDistance { get; set; }

        public MoveCommand(RobotObject robot) : base(robot) { }

        public override void Execute()
        {
            _robot.Move(ForwardDistance);
        }

        public override void Undo()
        {
            _robot.Move(-ForwardDistance);
        }
    }
}
