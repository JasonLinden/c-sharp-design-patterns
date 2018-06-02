using DocumentFormatter.ConcreteElement;

namespace DocumentFormatter.Visitables
{
    public class Text : Visitable
    {
        public Text(string text) : base(text) { }
    }
}
