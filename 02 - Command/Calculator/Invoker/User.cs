using _02___Command.Calculator.Command;
using _02___Command.Calculator.ConcreteCommand;
using _02___Command.Calculator.Receiver;
using System;
using System.Collections.Generic;

namespace _02___Command.Calculator.Invoker
{
    class User
    {
        // Initializers

        private CalculatorObject _calculator = new CalculatorObject();
        private List<AbstractCommand> _commands = new List<AbstractCommand>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);
            // Perform redo operations

            for (int i = 0; i < levels; i++)
            {
                if (_current < _commands.Count - 1)
                {
                    AbstractCommand command = _commands[_current++];
                    command.Execute();
                }
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);
            // Perform undo operations

            for (int i = 0; i < levels; i++)
            {
                if (_current > 0)
                {
                    AbstractCommand command = _commands[--_current] as AbstractCommand;
                    command.UnExecute();
                }
            }
        }

        public void Compute(char @operator, int operand)
        {
            // Create command operation and execute it

            AbstractCommand command = new CalculatorCommand(
              _calculator, @operator, operand);
            command.Execute();

            // Add command to undo list

            _commands.Add(command);
            _current++;
        }
    }
}
