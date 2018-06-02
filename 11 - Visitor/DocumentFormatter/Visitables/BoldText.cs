using DocumentFormatter.ConcreteElement;

namespace DocumentFormatter.Visitables
{
    public class BoldText : Visitable
    {
        public BoldText(string text) : base(text) { }
    }
}
