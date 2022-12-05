using Collections.Models;
using Service;
using Service.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EmployeeSalary
            //DateTime startDate = DateTime.Now.AddDays(2);
            //DateTime endDate = DateTime.Now.AddDays(25);

            //double salary = 2000;

            //IEmployeeService employeeService = new EmployeeService();

            //int result = employeeService.GetFilteredEmployeesCount(startDate, endDate, salary);
            //Console.WriteLine(result);
            #endregion

            #region KelvinAndCelsius
            //Celsius celsius = new Celsius(23);
            //Kelvin kelvin = celsius;

            //Console.WriteLine(kelvin.Degree);
            #endregion

            #region List
            List<int> nums = new List<int>() { 200, 300, 400, 500 };

            List<int> numbers = new List<int>();
            numbers.Add(5);
            numbers.Add(8);
            numbers.Add(11);
            numbers.Add(1);
            numbers.Add(112);
            numbers.Add(910);
            numbers.Add(3);

            //numbers.AddRange(nums);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.Contains(7);
            //Console.WriteLine(result);

            //var result = numbers.Find(m => m > 100);
            //Console.WriteLine(result);

            //var result = numbers.FindAll(m => m > 100);
            //foreach(var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.FindIndex(m => m > 100);
            //Console.WriteLine(result);

            //var result = numbers.FindLastIndex(m => m > 100);
            //Console.WriteLine(result);

            //numbers.Sort();

            //foreach(var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = numbers.ToArray();
            //var result2 = result.ToList();

            //var result = numbers.BinarySearch(5);

            //Console.WriteLine(result);
            //foreach(var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //if (result)
            //{
            //    Console.WriteLine("yes");
            //}

            //Console.WriteLine(numbers.Count);

            //foreach(var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

            //var result = names.FindAll(m => m == "Nicat");

            //foreach (var item in names)
            //{
            //    Console.WriteLine(item);
            //}

            //var seachText = Console.ReadLine();

            //var result = Search(seachText);

            //if(result.Count == 0)
            //{
            //    Console.WriteLine("Not Found");
            //}
            //else
            //{
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //Console.WriteLine(result.Count);

            List<Person> people = new List<Person>();
            people.Add(new Person { FullName = "Qoshqar Nerimanli", Birthday = DateTime.Now.AddDays(20), Salary = 1800 });
            people.Add(new Person { FullName = "Ramil Allahverdiyev", Birthday = DateTime.Now.AddDays(12), Salary = 2500 });
            people.Add(new Person { FullName = "Gultac Ceferova", Birthday = DateTime.Now.AddDays(10), Salary = 3000 });

            var result = people.FindAll(m => m.Salary > 2000 && m.FullName.StartsWith("R"));

            foreach (var person in result)
            {
                Console.WriteLine("Fullname : {0}, Birthday : {1}, Salary : {2}", person.FullName, person.Birthday, person.Salary);
            }


            #endregion

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add(1, "Resul");
            //hashtable.Add(2, "Nicat");
            //hashtable.Add(3, "Vuqar");

            //foreach(DictionaryEntry item in hashtable)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //SortedList sortedlist = new SortedList();
            //sortedlist.Add(1, "Resul");
            //sortedlist.Add(2, "Nicat");
            //sortedlist.Add(3, "Vuqar");

            //foreach (DictionaryEntry item in sortedlist)
            //{
            //    Console.WriteLine(item.Key + " " + item.Value);
            //}

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("salam");
            //arrayList.Add(155);

            //foreach (DictionaryEntry item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedList<string, string> list = new SortedList<string, string>();
            //list.Add("Admin", "Qosqar");
            //list.Add("Member", "Test");

            //foreach(KeyValuePair<string,string> item in list)
            //{
            //    if(item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}

            //Dictionary<string, string> dictionaryList = new Dictionary<string, string>();
            //dictionaryList.Add("Admin", "Ramil");

            //foreach(KeyValuePair<string,string> item in dictionaryList)
            //{
            //    if(item.Key == "Admin")
            //    {
            //        Console.WriteLine(item.Value);
            //    }
            //}
            //Console.WriteLine(dictionaryList["Admin"]);

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(12);
            //queue.Enqueue(23);
            //queue.Enqueue(34);

            //foreach(var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(34);
            //stack.Push(45);
            //stack.Push(56);

            //foreach(var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
        }
        //private static List<string> Search(string str)
        //{
        //    List<string> names = new List<string>() { "Resul", "Novreste", "Gultac", "Lale", "Nicat" };

        //    var result = names.FindAll(m => m.ToLower().Contains(str.ToLower()));

        //    return result;
        //}
    }
}
