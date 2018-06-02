using EmployeeManagement.AbstractElement;
using EmployeeManagement.ConcreteElement;
using System;
using Visitor.EmployeeManagement.Visitor;

namespace EmployeeManagement.ConcreteVisitor
{
    class VacationVisitor : IVisitor

    {
        public void Visit(Element element)
        {
            Employee employee = element as Employee;

            // Provide 3 extra vacation days

            employee.VacationDays += 3;
            Console.WriteLine("{0} {1}'s new vacation days: {2}",
                employee.GetType().Name, employee.Name,
                employee.VacationDays);
        }
    }
}