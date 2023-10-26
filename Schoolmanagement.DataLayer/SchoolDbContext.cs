using Microsoft.EntityFrameworkCore;
using Schoolmanagement.Entities;
using System;

namespace Schoolmanagement.DataLayer
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        public DbSet<Notice> Notices { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Library> Libraries { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<BookBorrow> BookBorrows { get; set; }

    } 
}
