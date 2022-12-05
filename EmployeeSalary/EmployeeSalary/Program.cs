using EmployeeSalary.Models;
using System;
using System.Collections.Generic;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { Age = 24, Salary = 2300 });
            list.Add(new Employee { Age = 20, Salary = 3400 });
            list.Add(new Employee { Age = 18, Salary = 6300 });
            list.Add(new Employee { Age = 34, Salary = 300 });
            list.Add(new Employee { Age = 39, Salary = 1300 });
            list.Add(new Employee { Age = 23, Salary = 4300 });
            
            AverageSalary(CheckAge,list);
        }
        public static bool CheckAge(Employee age)
        {
            return age.Age > 20 && age.Age < 40;
        }
        public static void AverageSalary(Predicate<Employee> predicate, List<Employee> list)
        {
            double sum = 0;
            double count = 0;
            foreach(var item in list)
            {
                if (predicate(item))
                {
                    sum += item.Salary;
                    count++;
                }
            }
            Console.WriteLine("Average salary is:  " + sum / count);
        }
    }
}
