using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public virtual Authour Authour { get; set; }
    }
}
