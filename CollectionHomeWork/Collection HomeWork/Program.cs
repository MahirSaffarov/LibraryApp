using Collection_HomeWork.Models;
using System;
using System.Collections.Generic;

namespace Collection_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Author> author = new List<Author>();

            author.Add(new Author { Name = "Anders", Surname = "Hejlsberg", Age = 61 });
            author.Add(new Author { Name = "James", Surname = "Gosling", Age = 67 });
            author.Add(new Author { Name = "Cavid", Surname = "Bashirov", Age = 29 });

            var result = author.FindAll(m => m.Age > 40);

            foreach(var item in result)
            {
                Console.WriteLine("Name: " + item.Name + "  " + "Surname: " + item.Surname);
            }
        }
    }
}
