using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        //public delegate void Power(int a, int b);
        
        static void Main(string[] args)
        {
            #region Array
            //int[] arr1 = new int[5];
            //int[] arr2 = new int[] { 1, 2, 3, 4, 5, 6 };
            //int[] arr3 = { 1, 2, 3, 4, 56, 7 };
            //foreach(int item in arr2)
            //{
            //    Console.WriteLine(item);
            //}
            //arr1[0] = 1;
            //arr1[1] = 45;
            //arr1[3] = 34;
            //Array.Resize(ref arr1, 20);
            //arr1[14] = 45;
            //foreach(int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Reverse(arr3);
            //foreach(int item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            //Array.Sort(arr3);
            //foreach(int item in arr3)
            //{
            //    Console.WriteLine(item);
            //}
            //int[,] arr = {{1,2,3,4,5,6 },{1,2,3,4,5,6 } };
            //Console.WriteLine(arr.Rank);
            #endregion

            #region Object
            //var stu1 = new
            //{
            //    name = "Mahir",
            //    surname = "Safarov",
            //    Age = 20,
            //    isMarried = false
            //};

            //Console.WriteLine(stu1.Age + " "+ stu1.name + " " + stu1.surname);
            //Console.WriteLine($"{stu1.name} {stu1.Age} {stu1.surname}");

            //object[] students = { stu1 };

            //foreach(var item in students)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Class
            //Car car = new Car();
            //car.name = "BMW";
            //car.color = "Red";
            //car.price = 30000.5;

            //Console.WriteLine(car.name);

            //Car car2 = new Car
            //{
            //    name = "Passat",
            //    color = "Black",
            //    price = 23000
            //};
            //Console.WriteLine(car2.color);

            Employee emp1 = new Employee();
            emp1.Name = "Mahir";
            emp1.Surname = "Safarov";
            emp1.Age = 20;
            Console.WriteLine(emp1.GetFullName());
            Console.WriteLine(emp1.GetFullData());
            
            #endregion      

        }

    }

    class Employee
    {
        public string Name;
        public string Surname;
        public int Age;

        public string GetFullName()
        {
            return Name + " " + Surname;
        }
        public string GetFullData()
        {
            return GetFullName() + Age;
        }
    }
    class Car
    {
        public string name;
        public string color;
        public double price;

    }
}
