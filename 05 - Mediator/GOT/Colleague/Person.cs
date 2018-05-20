using _05___Mediator.GOT.ColleagueBase;
using _05___Mediator.GOT.Mediator;

namespace _05___Mediator.GOT.Colleague
{
    /// <summary>
    /// Sends and receives messages via the passed Crier.
    /// 
    /// Acts as 'Colleague' within mediator pattern.
    /// </summary>
    internal class Person : IPerson
    {
        public string Name { get; }
        public Crier Crier { get; }

        public Person(string name, Crier crier)
        {
            Crier = crier;
            // Listen method subscribes to MessageReceived event handler.
            Crier.MessageReceived += Listen;

            Name = name;
        }

        /// <summary>
        /// Receives a message from source Person.
        /// </summary>
        /// <param name="message">Message received.</param>
        /// <param name="source">Person who sent the message.</param>
        public void Listen(string message, Person source)
        {
            // If source is self, ignore.
            if (source == this) return;

            // Output received message.
            System.Console.WriteLine($"{source} to {this}: '{message}'");
        }

        /// <summary>
        /// Sends passed message to all subscribed Persons via Crier.
        /// </summary>
        /// <param name="message">Message to be sent.</param>
        public void Say(string message)
        {
            Crier.Shout(message, this);
        }

        /// <summary>
        /// Overrides ToString() method.
        /// </summary>
        /// <returns>Name property value.</returns>
        public override string ToString() => Name;
    }
}
