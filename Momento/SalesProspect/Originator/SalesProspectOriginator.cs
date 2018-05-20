using Momento.SalesProspect.Memento;
using System;

namespace Momento.SalesProspect.Originator
{
    class SalesProspectOriginator
    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name

        public string Name
        {
            get { return _name; }
            set

            {
                _name = value;
                Console.WriteLine("Name:  " + _name);
            }
        }

        // Gets or sets phone

        public string Phone
        {
            get { return _phone; }
            set

            {
                _phone = value;
                Console.WriteLine("Phone: " + _phone);
            }
        }

        // Gets or sets budget

        public double Budget
        {
            get { return _budget; }
            set

            {
                _budget = value;
                Console.WriteLine("Budget: " + _budget);
            }
        }

        // Stores memento

        public MementoClass SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new MementoClass(_name, _phone, _budget);
        }

        // Restores memento

        public void RestoreMemento(MementoClass memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }
}
