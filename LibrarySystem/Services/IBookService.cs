using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get(int id);
        void Add(Book newBook);
        void Update(int id, Book book);
        void Delete(int id);

    }
}
