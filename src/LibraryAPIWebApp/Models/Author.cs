using System.ComponentModel.DataAnnotations;

namespace LibraryAPIWebApp.Models
{
    public class Author
    {
        public Author()
        {
            AuthorBooks = new List<AuthorBook>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Ім'я")]
        public string Name { get; set; }

        public string? Description { get; set; }

        public virtual ICollection<AuthorBook> AuthorBooks { get; set; }


    }
}
