﻿namespace LibraryAPIWebApp.Models
{
    public class AuthorBook
    {
        public int Id { get; set; }

       public int BookId { get; set; }

        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Book Book { get; set; }

    }
}
