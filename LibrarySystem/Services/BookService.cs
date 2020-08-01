using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySystem.Services
{
    public class BookService : IBookService
    {
        static List<Book> Database = loadDB();

        public static List<Book> loadDB()
        {
            List<Book> temp = new List<Book>();
            temp.Add(new Book { Id = 1, Name = "Book1", Author = "Author1" });
            temp.Add(new Book { Id = 2, Name = "Book2", Author = "Author2" });

            return temp;
        }

        // here we return whole list as a database
        public List<Book> GetAll()
        {
            return Database;
        }

        // here we return only one book id
        public Book Get(int id)
        {
            return Database.Find(book => book.Id==id);
        }

        public void Add(Book newBook)
        {
            Database.Add(newBook);
        }

        public void Update(int id, Book book)
        {
            Database.Remove(Database.Find(book=>book.Id==id));
            book.Id = id;
            Database.Add(book);
        }

        public void Delete(int id)
        {
            Database.Remove(Database.Find(book => book.Id == id));
        }
    }
}
