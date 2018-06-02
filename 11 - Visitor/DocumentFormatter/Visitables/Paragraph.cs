using DocumentFormatter.ConcreteElement;

namespace DocumentFormatter.Visitables
{
    public class Paragraph : Visitable
    {
        public Paragraph(string text) : base(text) { }
    }
}
