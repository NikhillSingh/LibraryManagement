using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Loan
    {
        public int LoanID { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime? DateReturned { get; set; }
        public string ISBN { get; set; }

        public Book Book { get; set; }
        public ICollection<Students> Students { get; set; }

    }
}
