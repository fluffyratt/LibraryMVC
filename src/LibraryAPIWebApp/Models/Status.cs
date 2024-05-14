using System.ComponentModel.DataAnnotations;

namespace LibraryAPIWebApp.Models
{
    public class Status
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Поле не повинно бути порожнім")]
        [Display(Name = "Статус")]
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
