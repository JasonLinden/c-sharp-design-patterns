using _03___Composite.Family.Component;

namespace _03___Composite.Family.Leaf
{
    class Uncle : IFamilyMember
    {
        public string Name { get; set; }

        public Uncle(string name)
        {
            Name = name;
        }
    }
}
