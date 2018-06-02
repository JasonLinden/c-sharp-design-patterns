using DocumentFormatter.Visitables;

namespace DocumentFormatter
{
    /// <summary>
    /// Converts passed IVisitable elements to BBCode.
    /// </summary>
    public class BbVisitor : ConcreteVisitor.Visitor
    {
        public void Visit(BoldText element)
        {
            Content += $"[b]{element.Text}[/b]";
        }

        public void Visit(Heading element)
        {
            Content += $"[heading]{element.Text}[/heading]";
        }

        public void Visit(Hyperlink element)
        {
            Content += $"[url={element.Url}]{element.Text}[/url]";
        }

        public void Visit(Paragraph element)
        {
            Content += $"\n\n{element.Text}\n\n";
        }
    }
}
