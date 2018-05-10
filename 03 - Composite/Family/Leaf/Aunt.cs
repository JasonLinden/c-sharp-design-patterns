using _03___Composite.Family.Component;

namespace _03___Composite.Family.Leaf
{
    class Aunt : IFamilyMember
    {
        public string Name { get; set; }

        public Aunt(string name)
        {
            Name = name;
        }
    }
}
