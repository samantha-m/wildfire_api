namespace wildfire_API.Models
{
    public class ReportedWildfire
    {
        public string Title { get; set; }

        public string Link { get; set; }

        public string Description { get; set; }

        public string PublicationDate { get; set; }

        public ReportedWildfire(string title, string link, string description, string publicationDate)
        {
            Title = title;
            Link = link;
            Description = description;
            PublicationDate = publicationDate;
        }
    }
}