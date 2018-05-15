using _05___Mediator.ColleagueBase;
using _05___Mediator.MediatorBase;
using System;

namespace _05___Mediator.Colleague
{
    /// <summary>
    /// A Concrete Colleague class
    /// </summary>
    class NorthConcessionStand : ConcessionStand
    {
        // Constructor
        public NorthConcessionStand(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message)
        {
            Console.WriteLine("North Concession Stand sends message: " + message);
            mediator.SendMessage(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("North Concession Stand gets message: " + message);
        }
    }
}
