using BookAuthor.Models;
using System;
using System.Collections.Generic;

namespace BookAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book { Name = "Xəmsə", Author = "Nizami Gencevi" });
            books.Add(new Book { Name = "Bize inan", Author = "İlyas Efendiyev" });
            books.Add(new Book { Name = "İsgəndərnamə", Author = "Nizami Gencevi" });
            books.Add(new Book { Name = "Mavi melekler", Author = "Cingiz Abdullayev" });

            GetName(CheckName, books);
            
        }
        public static bool CheckName(Book name)
        {
            return name.Author == "Nizami Gencevi";
        }
        public static void GetName(Predicate<Book> predicate, List<Book> list)
        {
            int count = 0;
            foreach(var item in list)
            {
                if (predicate(item))
                {
                    Console.WriteLine(item.Author + " " + item.Name);
                    count++;
                }
            }
            Console.WriteLine("\nThere are " + count + " books in the list.");
        }

        
    }
}
