using Visitor.EmployeeManagement.Visitor;

namespace EmployeeManagement.AbstractElement
{
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
    }
}
