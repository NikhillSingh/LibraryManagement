using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Author
    {
        public int AuthorID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Contact { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Book Book { get; set; }
    }
}
