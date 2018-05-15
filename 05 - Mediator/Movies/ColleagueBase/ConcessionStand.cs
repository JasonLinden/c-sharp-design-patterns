using _05___Mediator.MediatorBase;

namespace _05___Mediator.ColleagueBase
{
    /// <summary>
    /// The Colleague abstract class, representing an entity involved in the conversation which should receive messages.
    /// </summary>
    abstract class ConcessionStand
    {
        protected IMediator mediator;

        public ConcessionStand(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
