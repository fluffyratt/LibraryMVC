using System.ComponentModel.DataAnnotations;

namespace LibraryAPIWebApp.Models
{
    public class Category
    {
        public Category()
        {
            Books = new List<Book>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public string Desctiption { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
