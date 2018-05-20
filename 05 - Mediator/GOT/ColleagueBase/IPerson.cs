using _05___Mediator.GOT.Colleague;

namespace _05___Mediator.GOT.ColleagueBase
{
    internal interface IPerson
    {
        void Listen(string message, Person source);
        void Say(string message);
    }
}
