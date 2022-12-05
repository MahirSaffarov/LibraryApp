using Domain.Models;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class LibraryService : ILibraryService
    {
        public List<Books> GetLibraries(Predicate<Books> predicate)
        {
            var libraries = GetAllBooks();
            return libraries.FindAll(predicate);
        }
        private List<Books> GetAllBooks()
        {
            List<Books> list = new();

            Books book1 = new()
            {
                Name = "Xosrov",
                Author = "Nizami",
                Id = 1
            };
            Books book2 = new()
            {
                Name = "SikayetName",
                Author = "Fuzuli",
                Id = 2
            };

            list.Add(book1);
            list.Add(book2);

            return list;
        }

            public List<Library> Libraries()
        {
            var libraries = GetAll();

            foreach (var library in libraries)
            {
                foreach(var books in library.Books)
                {
                    Console.WriteLine(books.Name + " " + books.Author);
                }
            }
            return libraries;
        }

        private List<Library> GetAll()
        {
            List<Library> list = new();

            Books book1 = new()
            {
                Name = "Xosrov",
                Author = "Nizami",
                Id = 1
            };
            Books book2 = new()
            {
                Name = "SikayetName",
                Author = "Fuzuli",
                Id = 2
            };

            List<Books> books1 = new() { book1 };
            List<Books> books2 = new() { book2 };

            Library library1 = new()
            {
                Books = books1,
            };
            Library library2 = new()
            {
                Books = books2,
            };

            list.Add(library1);
            list.Add(library2);

            return list;
        }
    }
}
