namespace LibraryManagementSystem.Models
{
    public class BookViewModel
    {
        // Book Info
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public DateTime PublishDate { get; set; }
        public int CopiesAvailable { get; set; }

        // Author Info
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } // Merge Name & Surname
    }
}