using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement
{
    public class LMContext:DbContext
    {
        static string connection= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryManagement;Integrated Security=True";

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
