using Momento.SalesProspect.Memento;

namespace Momento.SalesProspect.Caretaker
{
    class ProspectMemory
    {
        private MementoClass _memento;

        // Property

        public MementoClass Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }
}
