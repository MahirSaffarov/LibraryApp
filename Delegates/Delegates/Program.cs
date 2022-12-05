using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        //public delegate bool CheckNum(int nums);
        static void Main(string[] args)
        {
            #region Nullable
            //string a = null;
            //Console.WriteLine(a);

            //Person person = null;

            //int? b = null;
            //Console.WriteLine(b);

            //Person person1 = new Person();
            //Console.WriteLine(person1.GetData(null));

            //Person person2 = new Person();
            //Console.WriteLine(person2.c);
            #endregion

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(SumEvenNums(arr));
            //Console.WriteLine(SumGreaterThanFour(arr));
            //Console.WriteLine(Sum(CheckOddNums, arr));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result = numbers.FindAll(m => m % 2 == 0 && m > 4);
            //Console.WriteLine(result.Count);

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine(Sum2(Check, list));

            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result = nums.FindAll(m => m > 5);
            //SumLoop(result);

        }   
        public static void SumLoop(List<int> list)
        {
            int nums = 0;
            foreach (var item in list)
            {
                nums += item;
            }
            Console.WriteLine(nums);
        }
        public static bool Check(int num)
        {
            return num % 2 == 0;
        }
        public static int Sum2(Predicate<int> predicate, List<int> list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        public static bool CheckOddNums(int number)
        {
            return number % 2 != 0;
        }
        public static int Sum(Predicate<int> predicate, int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }
            return sum;
        }
        public static int SumEvenNums(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
        public static int SumGreaterThanFour(int[] arr)
        {
            int sum = 0;
            foreach (var item in arr)
            {
                if (item > 4)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
    class Person
    {
        public int? c { get; set; }
        public string GetData(int? d)
        {
            if (d is null)
            {
                return "null";
            }
            return "not null";
        }
    }
}
