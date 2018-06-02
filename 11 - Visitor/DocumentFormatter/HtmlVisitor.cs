using DocumentFormatter.Visitables;

namespace DocumentFormatter
{
    /// <summary>
    /// Converts passed IVisitable elements to HTML.
    /// </summary>
    public class HtmlVisitor : DocumentFormatter.ConcreteVisitor.Visitor
    {
        public void Visit(BoldText element)
        {
            Content += $"<b>{element.Text}</b>";
        }

        public void Visit(Heading element)
        {
            Content += $"<h{element.Level}>{element.Text}</h{element.Level}>";
        }

        public void Visit(Hyperlink element)
        {
            Content += $"<a href=\"{element.Url}\">{element.Text}</a>";
        }

        public void Visit(Paragraph element)
        {
            Content += $"<p>{element.Text}</p>";
        }

        public void Visit(Text element)
        {
            Content += $"<span>{element.Text}</span>";
            // Arguably we should throw a NotImplementedException, 
            // since a plain Text element in HTML is typically a paragraph.
            //throw new NotImplementedException();
        }
    }
}
