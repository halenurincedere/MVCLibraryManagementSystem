namespace LibraryManagementSystem.Models
{
    public class AuthorViewModel
    {
        // Author Info
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        // To show books by author
        public List<BookViewModel> Books { get; set; } = new List<BookViewModel>();
    }
}