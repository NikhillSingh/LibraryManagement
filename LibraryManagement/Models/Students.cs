using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class Students
    {
        public int StudentsID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int YearLevel { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public int Contact { get; set; }
        public Loan Loan { get; set; }
    }
}
