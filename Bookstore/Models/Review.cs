namespace Bookstore.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string AppUser { get; set; }
        public string Comment { get; set; }
        public string? Rating { get; set; }

    }
}
