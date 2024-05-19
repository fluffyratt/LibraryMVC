﻿using System.ComponentModel.DataAnnotations;

namespace LibraryAPIWebApp.Models
{
    public class Status
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

    }
}
