using _06___Flyweight.Publication.ConcreteFlyweight;
using _06___Flyweight.Publication.Flyweight_Base;
using System;
using System.Collections.Generic;

namespace _06___Flyweight.Publication.FlyweightFactory
{
    public class Library
    {
        /// Stores all publication data privately. Should not be publically accessible
        /// since we want to force access through GetPublication() method.
        protected Dictionary<Tuple<Author, string, PublicationType>, IPublication> Publications =
        new Dictionary<Tuple<Author, string, PublicationType>, IPublication>();

        /// Get the count of all publications in library.
        public int GetPublicationCount => Publications.Count;

        /// Retrieve a Publication by passed key Tuple.
        /// If an item with matching key exists, retrieve from private Publications property.
        /// Otherwise, generate a new instance, add to list, and return result.
        public IPublication GetPublication(Tuple<Author, string, PublicationType> key)
        {
            IPublication publication = null;
            try
            {
                if (Publications.ContainsKey(key))
                {
                    publication = Publications[key];
                }
                else
                {
                    switch (key.Item3)
                    {
                        case PublicationType.Book:
                            // Create a new Book (ConcreteFlyweight) example.
                            publication = new Book(
                            author: key.Item1,
                            pageCount: 662,
                            publisher: new Publisher("DAW Books"),
                            title: key.Item2
                            );
                            break;
                        case PublicationType.GraphicNovel:
                            // Create a new GraphicNovel (ConcreteFlyweight) example.
                            publication = new GraphicNovel(
                            author: key.Item1,
                            illustrator: new Illustrator(key.Item1.Name),
                            publisher: new Publisher("Drawn & Quarterly"),
                            title: key.Item2
                            );
                            break;
                        default:
                            throw new ArgumentException($"[PublicationType.{key.Item3}] is not configured. Publication ('{key.Item2}' by {key.Item1.Name}) cannot be created.");
                    }
                    // ...
                    // Add new publication to global list.
                    Publications.Add(key, publication);
                }
            }
            catch (ArgumentException exception)
            {
            }

            // Return publication, whether newly-created or existing record.
            return publication;
        }
    }
}
