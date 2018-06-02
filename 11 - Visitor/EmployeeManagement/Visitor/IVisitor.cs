using EmployeeManagement.AbstractElement;

namespace Visitor.EmployeeManagement.Visitor
{
    public interface IVisitor
    {
        void Visit(Element element);
    }
}
