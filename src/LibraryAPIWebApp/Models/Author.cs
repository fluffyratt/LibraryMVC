namespace LibraryAPIWebApp.Models
{
    public class Author
    {
        public Author()
        {
            AuthorBooks = new List<AuthorBook>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }


    }
}
