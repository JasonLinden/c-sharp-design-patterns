using DocumentFormatter;
using DocumentFormatter.ObjectStructure;
using DocumentFormatter.Visitables;
using EmployeeManagement;
using EmployeeManagement.ConcreteVisitor;
using EmployeeManagement.ObjectStructure;
using System;

namespace _11___Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Employee Management

            // Setup employee collection
            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'
            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user
            Console.ReadKey();

            #endregion

            #region Document Formatting

            // Create a new document.
            var document = new Document();

            // Add some elements to the document.
            document.Elements.Add(new Text("This is plain text."));
            document.Elements.Add(new Hyperlink("Hyperlink to Airbrake.io", "http://airbrake.io"));
            document.Elements.Add(new Paragraph("Lorem ipsum dolor sit amet, consectetur adipiscing elit."));
            document.Elements.Add(new BoldText("Important text to bold!"));

            // Create a few visitors.
            var html = new HtmlVisitor();
            var markdown = new MarkdownVisitor();
            var bbCode = new BbVisitor();

            // Force document to accept passed visitors, 
            // which will each uniquely alter output.
            document.Accept(html);
            document.Accept(markdown);
            document.Accept(bbCode);

            // Log each visitor's output.
            Console.WriteLine("HTML");
            Console.WriteLine(html.ToString());

            Console.WriteLine("Markdown");
            Console.WriteLine(markdown.ToString());

            Console.WriteLine("BBCode");
            Console.WriteLine(bbCode.ToString());

            #endregion

        }
    }
}
