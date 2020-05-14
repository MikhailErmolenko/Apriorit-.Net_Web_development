using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Models
{
    public class Authour
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Book> Books { get; set; }
    }
}
