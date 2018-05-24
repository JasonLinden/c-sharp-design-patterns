using _02___Command.Calculator.Invoker;
using _02___Command.FastFood;
using _02___Command.FastFood.Invoker;
using _02___Command.Robot.Command;
using _02___Command.Robot.ConcreteCommand;
using _02___Command.Robot.Invoker;
using _02___Command.Robot.Receiver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Command
{
    // Created a test branch to see how it all works
    class Program
    {
        static void Main(string[] args)
        {
            // Try fix the robot example. Client does not need to know about receiver.
            // Basiicall the idea is that we are passing the receiver to the command and then passing the command to the
            // invoker which will then invoke the command on the relevant receiver.
            // So the invoker has the power of turing the light on.
            #region Robot

            var robot = new RobotObject();
            var controller = new RobotController();

            // Setting up the commands
            var move = new MoveCommand(robot);
            move.ForwardDistance = 1000;
            controller.Commands.Enqueue(move);

            var rotate = new RotateLeftCommand(robot);
            rotate.LeftRotationAngle = 45;
            controller.Commands.Enqueue(rotate);

            var scoop = new TakeSampleCommand(robot);
            scoop.TakeSample = true;
            controller.Commands.Enqueue(scoop);

            // Executing the commands
            controller.ExecuteCommands();
            controller.UndoCommands(3);

            #endregion

            #region Calculator

            // Create user and let her compute
            User user = new User();

            // User presses calculator buttons
            user.Compute('+', 100);
            user.Compute('-', 50);
            user.Compute('*', 10);
            user.Compute('/', 2);

            // Undo 4 commands
            user.Undo(4);

            // Redo 3 commands
            user.Redo(3);

            #endregion

            #region Fast Food

            Patron patron = new Patron();
            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 2, 2.59));
            patron.ExecuteCommand();

            patron.SetCommand(1 /*Add*/);
            patron.SetMenuItem(new MenuItem("Drink", 2, 1.19));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Remove the french fries
            patron.SetCommand(3 /*Remove*/);
            patron.SetMenuItem(new MenuItem("French Fries", 2, 1.99));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            //Now we want 4 hamburgers rather than 2
            patron.SetCommand(2 /*Edit*/);
            patron.SetMenuItem(new MenuItem("Hamburger", 4, 2.59));
            patron.ExecuteCommand();

            patron.ShowCurrentOrder();

            Console.ReadKey();

            #endregion
        }
    }
}
