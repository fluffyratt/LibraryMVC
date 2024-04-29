using Microsoft.EntityFrameworkCore;

namespace LibraryAPIWebApp.Models
{
   
    public class LibrariAPIContext : DbContext
    {
        public virtual DbSet<Author> Authors { get; set; }

        public virtual DbSet<AuthorBook> AuthorBooks { get; set; }

        public virtual DbSet<Book> Books { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public LibrariAPIContext(DbContextOptions <LibrariAPIContext> options)
            : base(options)
        {
            Database.EnsureCreated();
     
        }
    }
}
