using DocumentFormatter.Element;

namespace DocumentFormatter.Visitor
{
    public interface IVisitor
    {
        void Visit(IVisitable visitable);
    }
}
