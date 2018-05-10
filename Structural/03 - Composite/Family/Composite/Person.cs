using _03___Composite.Family.Component;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03___Composite.Family.Composite
{
    class Person : IFamilyMember, IEnumerable<IFamilyMember>
    {
        /// <summary>
        /// Private list of children belonging to this person.
        /// </summary>
        private Lazy<List<IFamilyMember>> _children = new Lazy<List<IFamilyMember>>();
        private List<IFamilyMember> Children => _children.Value;

        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Add a child to the list of children.
        /// </summary>
        /// <param name="child">Child to add.</param>
        public void AddChild(IFamilyMember child)
        {
            Children.Add(child);
        }

        /// <summary>
        /// Remove a children from the list of children.
        /// </summary>
        /// <param name="child">Child to remove.</param>
        public void RemoveChild(IFamilyMember child)
        {
            Children.Remove(child);
        }

        /// <summary>
        /// Get a child instance by index.
        /// </summary>
        /// <param name="index">Index of child to retrieve.</param>
        /// <returns>Child record.</returns>
        public IFamilyMember GetChild(int index)
        {
            return Children[index];
        }

        /// <summary>
        /// Get a child instance by name.
        /// </summary>
        /// <param name="name">Name of child to retrieve.</param>
        /// <returns>Child record.</returns>
        public IFamilyMember GetChild(string name)
        {
            return Children.Where(c => c.Name == name).First();
        }

        /// <summary>
        /// Get collection of children.
        /// </summary>
        /// <returns>Collection of children.</returns>
        public IEnumerable<IFamilyMember> GetChildren()
        {
            return Children;
        }

        public IEnumerator<IFamilyMember> GetEnumerator()
        {
            return ((IEnumerable<IFamilyMember>)_children).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<IFamilyMember>)_children).GetEnumerator();
        }

        public void LogChildren(int depth)
        {
            // Check if person has any children.
            if (GetChildren().Any())
            {
                // Output person's name, number of children, and list of child names.
                Console.WriteLine($"Depth - { depth } - {Name} has ({GetChildren().Count()}) children:\n{String.Join("\n", GetChildren().Select(c => c.Name))}");
            }
            else
            {
                // No children to output.
                Console.WriteLine($"Depth - { depth } - {Name} has no children.");
            }
        }
    }
}