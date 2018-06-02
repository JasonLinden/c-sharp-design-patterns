using DocumentFormatter.ConcreteElement;

namespace DocumentFormatter.Visitables
{
    public class Hyperlink : Visitable
    {
        public string Url { get; set; }

        public Hyperlink(string text, string url) : base(text)
        {
            Url = url;
        }
    }
}
