using _01___Chain_of_Responsibility.Publication;
using _01___Chain_of_Responsibility.Publication.ConcreteHandler;
using _01___Chain_of_Responsibility.Publication.Specification;
using _01___Chain_of_Responsibility.Restaurant;
using _01___Chain_of_Responsibility.Restaurant.ConcreteHandler;
using _01___Chain_of_Responsibility.Restaurant.Handler;
using System;
using System.Collections.Generic;

namespace _01___Chain_of_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Publication

            // Create a list of books to be published, including cover type and publication cost.
            var books = new List<Book> {
                new Book("The Stand", "Stephen King", CoverType.Paperback, 35000),
                new Book("The Hobbit", "J.R.R. Tolkien", CoverType.Paperback, 25000),
                new Book("The Name of the Wind", "Patrick Rothfuss", CoverType.Digital, 7500),
                new Book("To Kill a Mockingbird", "Harper Lee", CoverType.Hard, 65000),
                new Book("1984", "George Orwell", CoverType.Paperback, 22500) ,
                new Book("Jane Eyre", "Charlotte Brontë", CoverType.Hard, 82750)
            };

            // Create specifications for individual cover types.
            var digitalCoverSpec = new Specification<Book>(book => book.CoverType == CoverType.Digital);
            var hardCoverSpec = new Specification<Book>(book => book.CoverType == CoverType.Hard);
            var paperbackCoverSpec = new Specification<Book>(book => book.CoverType == CoverType.Paperback);

            // Create budget spec for cost exceeding $75000.
            var extremeBudgetSpec = new Specification<Book>(book => book.PublicationCost >= 75000);
            // Create budget spec for cost between $50000 and $75000.
            var highBudgetSpec = new Specification<Book>(book => book.PublicationCost >= 50000 && book.PublicationCost < 75000);
            // Create budget spec for cost between $25000 and $50000.
            var mediumBudgetSpec = new Specification<Book>(book => book.PublicationCost >= 25000 && book.PublicationCost < 50000);
            // Create budget spec for cost below $25000.
            var lowBudgetSpec = new Specification<Book>(book => book.PublicationCost < 25000);

            // Default spec, always returns true.
            var defaultSpec = new Specification<Book>(book => true);

            // Create publication process instance, used to pass Action<T> to Employee instances.
            var publicationProcess = new PublicationProcess();

            // Create employees with various positions.
            var ceo = new Employee<Book>("Alice", Position.CEO, publicationProcess.PublishBook);
            var president = new Employee<Book>("Bob", Position.President, publicationProcess.PublishBook);
            var cfo = new Employee<Book>("Christine", Position.CFO, publicationProcess.PublishBook);
            var director = new Employee<Book>("Dave", Position.DirectorOfPublishing, publicationProcess.PublishBook);
            // Default employee, used as successor of CEO and to handle unpublishable books.
            var defaultEmployee = new Employee<Book>("INVALID", Position.Default, publicationProcess.FailedPublication);

            // Director can handle digital low budget only.
            director.SetSpecification(digitalCoverSpec.And(lowBudgetSpec));

            // CFO can handle digital/paperbacks that are medium or high budget.
            cfo.SetSpecification(digitalCoverSpec.Or(paperbackCoverSpec).And(mediumBudgetSpec.Or(highBudgetSpec)));

            // President can handle all medium/high budget.
            president.SetSpecification(mediumBudgetSpec.Or(highBudgetSpec));

            // CEO can handle all extreme budget.
            ceo.SetSpecification(extremeBudgetSpec);

            // Default employee can handle only default specification (all).
            defaultEmployee.SetSpecification(defaultSpec);

            // Set chain of responsibility: CEO > President > CFO > Director.
            director.SetSuccessor(cfo);
            cfo.SetSuccessor(president);
            president.SetSuccessor(ceo);
            ceo.SetSuccessor(defaultEmployee);

            // Loop through books, trying to publish, starting at bottom of chain of responsibility (Director).
            books.ForEach(book => director.PublishBook(book));

            #endregion

            // TODO => Add specification pattern here.
            #region Restaurant

            //Create the chain links
            Approver jennifer = new HeadChef();
            Approver mitchell = new PurchasingManager();
            Approver olivia = new GeneralManager();

            //Create the chain
            jennifer.SetSupervisor(mitchell);
            mitchell.SetSupervisor(olivia);

            // Generate and process purchase requests
            PurchaseOrder p = new PurchaseOrder(1, 20, 69, "Spices");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(2, 300, 1389, "Fresh Veggies");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(3, 500, 4823.99, "Beef");
            jennifer.ProcessRequest(p);

            p = new PurchaseOrder(4, 4, 12099, "Ovens");
            jennifer.ProcessRequest(p); 

            #endregion

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Defines success/failure actions to use as Actions if Employee can approve a publication.
    /// </summary>
    public class PublicationProcess
    {
        public void PublishBook(Book book)
        {
            book.Publish();
        }

        public void FailedPublication(Book book)
        {
            Console.WriteLine($"Unable to publish: {book}.");
        }
    }
}
