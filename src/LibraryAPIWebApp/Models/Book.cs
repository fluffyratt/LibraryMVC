namespace LibraryAPIWebApp.Models
{
    public class Book
    {
        public Book()
        {
            AuthorBooks = new List<AuthorBook>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public string? Description { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection <AuthorBook> AuthorBooks { get; set; }
    }
}
