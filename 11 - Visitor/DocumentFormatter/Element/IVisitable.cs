using DocumentFormatter.Visitor;

namespace DocumentFormatter.Element
{
    public interface IVisitable
    {
        string Text { get; set; }

        void Accept(IVisitor visitor);
    }
}
