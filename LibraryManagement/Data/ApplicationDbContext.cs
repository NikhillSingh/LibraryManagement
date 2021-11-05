using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LibraryManagement.Models;

namespace LibraryManagement.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibraryManagement.Models.Book> Book { get; set; }
        public DbSet<LibraryManagement.Models.Students> Students { get; set; }
        public DbSet<LibraryManagement.Models.Author> Author { get; set; }
        public DbSet<LibraryManagement.Models.Publisher> Publisher { get; set; }
        public DbSet<LibraryManagement.Models.Loan> Loan { get; set; }
    }
}
