using DocumentFormatter.Visitables;

namespace DocumentFormatter
{
    /// <summary>
    /// Converts passed IVisitable elements to Markdown.
    /// </summary>
    public class MarkdownVisitor : ConcreteVisitor.Visitor
    {
        public void Visit(BoldText element)
        {
            Content += $"**{element.Text}**";
        }

        public void Visit(Heading element)
        {
            // Add seperator character for each Level.
            Content += $"{('#', element.Level)} {element.Text}";
        }

        public void Visit(Hyperlink element)
        {
            Content += $"[{element.Text}]({element.Url})";
        }

        public void Visit(Paragraph element)
        {
            Content += $"\n\n{element.Text}\n\n";
        }
    }
}
