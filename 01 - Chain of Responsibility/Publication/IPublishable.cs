namespace _01___Chain_of_Responsibility.Publication
{
    public interface IPublishable
    {
        string Author { get; set; }
        CoverType CoverType { get; }
        decimal PublicationCost { get; set; }
        void Publish();
        string Title { get; set; }
    }
}
