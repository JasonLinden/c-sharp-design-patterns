namespace _04___Iterator.Books
{
    /// <summary>
    /// Simple Book class.
    /// </summary>
    public class Book : IBook
    {
        public string Author { get; set; }
        public int PageCount { get; set; }
        public string Title { get; set; }

        public Book() { }

        public Book(string title, string author)
        {
            Author = author;
            Title = title;
        }

        public Book(string title, string author, int pageCount)
        {
            Author = author;
            PageCount = pageCount;
            Title = title;
        }

        public override string ToString()
        {
            return $"'{Title}' by {Author} at {PageCount} pages";
        }
    }
}
