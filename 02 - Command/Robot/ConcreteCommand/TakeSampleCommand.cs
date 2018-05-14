using _02___Command.Robot.Command;
using _02___Command.Robot.Receiver;

namespace _02___Command.Robot.ConcreteCommand
{
    public class TakeSampleCommand : RobotCommandBase
    {
        public bool TakeSample { get; set; }

        public TakeSampleCommand(RobotObject robot) : base(robot) { }

        public override void Execute()
        {
            _robot.TakeSample(true);
        }

        public override void Undo()
        {
            _robot.TakeSample(false);
        }
    }
}
