using PersonSalary.Models;
using System;
using System.Collections.Generic;

namespace PersonSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person { Name = "Mahir", Surname = "Safarov", Adress = "Nesimi rayonu", Salary = 2000 });
            list.Add(new Person { Name = "Cavid", Surname = "Basirov", Adress = "Yasamal rayonu", Salary = 5000 });
            list.Add(new Person { Name = "Nicat", Surname = "Rehmanov", Adress = "Xetai rayonu", Salary = 3000 });
            list.Add(new Person { Name = "Resul", Surname = "Qafarli", Adress = "Sebayil rayonu", Salary = 900 });

            PersonInfo(CheckSalary, list);
        }
        public static bool CheckSalary(Person person)
        {
            return person.Salary > 1000;
        }
        public static void PersonInfo(Predicate<Person> predicate, List<Person> list)
        {
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    Console.WriteLine($"{item.Name} -- {item.Surname} -- {item.Adress}");

                }
            }
        }
    }
}
