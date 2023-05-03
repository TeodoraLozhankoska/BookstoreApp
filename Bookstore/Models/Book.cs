namespace Bookstore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int YearPublished { get; set; }
        public int NumPages { get; set; }
        public string? Description { get; set; }
        public string? Publisher { get; set; }
        public string? FrontPage { get; set; }
        public string? DownloadURL { get; set; }
        public int AuthorId { get; set; }
       


    }
}
