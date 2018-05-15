using _05___Mediator.ColleagueBase;

namespace _05___Mediator.MediatorBase
{
    /// <summary>
    /// The Mediator interface, which defines a send message method which the concrete mediators must implement.
    /// </summary>
    interface IMediator
    {
        void SendMessage(string message, ConcessionStand concessionStand);
    }
}
