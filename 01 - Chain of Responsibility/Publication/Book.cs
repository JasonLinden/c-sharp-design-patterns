namespace _01___Chain_of_Responsibility.Publication
{
    /// <summary>
    /// Book class that includes author, title, publication cost, and cover type.
    /// </summary>
    public class Book : IPublishable
    {
        public string Author { get; set; }
        public CoverType CoverType { get; set; }
        public decimal PublicationCost { get; set; }
        public string Title { get; set; }

        public Book(string title, string author, CoverType coverType, decimal publicationCost)
        {
            this.Author = author;
            this.PublicationCost = publicationCost;
            this.CoverType = coverType;
            this.Title = title;
        }

        /// <summary>
        /// Simulates publication of the book via confirmation output.
        /// </summary>
        public void Publish()
        {
            System.Console.WriteLine($"Successfully published {this}.");
        }

        /// <summary>
        /// Converts this Book object to string format.
        /// </summary>
        /// <returns>Formatted book information.</returns>
        public override string ToString()
        {
            return $"{CoverType} cover '{Title}' by {Author} for {PublicationCost:C2}";
        }
    }
}
