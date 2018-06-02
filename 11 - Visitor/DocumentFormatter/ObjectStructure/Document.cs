using DocumentFormatter.ConcreteElement;
using DocumentFormatter.Visitor;
using System.Collections.Generic;

namespace DocumentFormatter.ObjectStructure
{
    /// <summary>
    /// Creates a basic virtual document composed of numerous elements.
    /// </summary>
    public class Document
    {
        public List<Visitable> Elements = new List<Visitable>();

        /// <summary>
        /// Accept the passed IVisitor for each element.
        /// </summary>
        /// <param name="visitor">Visitor to accept.</param>
        public void Accept(IVisitor visitor)
        {
            foreach (var element in Elements)
            {
                element.Accept(visitor);
            }
        }
    }
}
