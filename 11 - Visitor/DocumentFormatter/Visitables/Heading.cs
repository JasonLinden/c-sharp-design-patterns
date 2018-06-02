using DocumentFormatter.ConcreteElement;

namespace DocumentFormatter.Visitables
{
    public class Heading : Visitable
    {
        public int Level { get; set; }

        public Heading(string text, int level) : base(text)
        {
            Level = level;
        }
    }
}
