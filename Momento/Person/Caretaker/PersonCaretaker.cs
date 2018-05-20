using Momento.Person.Memento;
using System.Collections.Generic;

namespace Momento.Person.Caretaker
{
    public class PersonCaretaker
    {
        readonly Stack<PersonMemento> _mementos = new Stack<PersonMemento>();

        public PersonMemento GetMemento()
        {
            return _mementos.Pop();
        }

        public void Add(PersonMemento memento)
        {
            _mementos.Push(memento);
        }
    }
}
