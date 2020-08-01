using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Data
{
    public class LibraryDataContext : DbContext
    {
        public LibraryDataContext(DbContextOptions<LibraryDataContext> options) : base(options)
        {

        }

        public DBset<Book> Books { get; set; }
    }
}
