using Momento.Person.Memento;
using System;

namespace Momento.Person
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }

        public PersonMemento CreateUnDo()
        {
            return new PersonMemento(FirstName, LastName, CellPhone, Address);
        }

        public void UnDo(PersonMemento memento)
        {
            FirstName = memento.FirstName;
            LastName = memento.LastName;
            CellPhone = memento.CellPhone;
            Address = memento.Address;
        }

        public void ShowInfo()
        {
            Console.WriteLine("FIRST NAME: {0}", FirstName);
            Console.WriteLine("LAST NAME: {0}", LastName);
            Console.WriteLine("ADDRESS: {0}", Address);
            Console.WriteLine("CELLPHONE: {0}", CellPhone);
        }
    }
}
