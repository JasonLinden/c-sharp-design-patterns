using Momento.Person;
using Momento.Person.Caretaker;
using Momento.SalesProspect.Caretaker;
using Momento.SalesProspect.Originator;
using System;

namespace _06___Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Person

            var person = new Person
            {
                Address = "Under the Bridge 171",
                CellPhone = "122011233185",
                FirstName = "John",
                LastName = "Doe"
            };

            var caretaker = new PersonCaretaker();
            caretaker.Add(person.CreateUnDo());

            person.ShowInfo();
            Console.WriteLine();

            person.Address = "Under the Tree 119";
            caretaker.Add(person.CreateUnDo());

            person.ShowInfo();
            Console.WriteLine();

            person.CellPhone = "987654321";
            person.ShowInfo();
            Console.WriteLine();

            person.UnDo(caretaker.GetMemento());
            person.ShowInfo();
            Console.WriteLine();

            person.UnDo(caretaker.GetMemento());
            person.ShowInfo();
            Console.WriteLine();

            #endregion

            #region Sales Prospect

            SalesProspectOriginator s = new SalesProspectOriginator
            {
                Name = "Noel van Halen",
                Phone = "(412) 256-0990",
                Budget = 25000.0
            };

            // Store internal state
            ProspectMemory m = new ProspectMemory
            {
                Memento = s.SaveMemento()
            };

            // Continue changing originator
            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();

            #endregion
        }
    }
}
