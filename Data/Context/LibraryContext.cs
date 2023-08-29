using Application;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
   public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options): base(options) { }
        public DbSet<Library_Student> Library_Students { get; set; }    
        public DbSet<Book> Boooks { get; set; }    
    }
}
