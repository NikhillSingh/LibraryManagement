using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Book
    {
        [Key]
        public string  ISBN { get; set; }

        public string Title { get; set; }
        public string AuthorName { get; set; }
        public int YearPublished { get; set; }
        public decimal Price { get; set; }
        public string PublisherName { get; set; }

        public Loan Loan { get; set; }

    }
}
