using Indexer_Reflection_Controllers.Models;
using Indexer_Reflection_Controllers.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Reflection_Controllers.Services
{
    public class BookService : IBookService
    {
        public List<int> GetCount(Predicate<Book> predicate)
        {
            var list = AddBook();

            var result = list.FindAll(predicate).Count;



            List<int> bookCount = new List<int> { result };

            return bookCount;
        }
        private List<Book> AddBook()
        {
            List<Book> books = new();
            Book book1 = new()
            {
                Name = "Xosrov",
                Author = "Nizami"
            };

            Book book2 = new()
            {
                Name = "Xosrov",
                Author = "Nizami"
            };

            Book book3 = new()
            {
                Name = "Xosrov",
                Author = "Fuzuli"
            };

            Book book4 = new()
            {
                Name = "Xosrov",
                Author = "Nizami"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);

            return books;
        }
    }
}
