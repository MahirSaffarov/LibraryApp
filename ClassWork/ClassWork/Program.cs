using ClassWork.Models;
using System;
using static ClassWork.Models.Enum;

namespace ClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Please enter number one: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Please enter number two: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Your answer: "+a.GetMulti(b));

            //Console.Write("Please enter a number: ");
            //int d = Convert.ToInt32(Console.ReadLine());
            //Console.Write($"Your answer"+ d.GetSqrt(d));
            int a = Convert.ToInt32(Console.ReadLine());
            CheckWeekDays(a);
        }
        public static void CheckWeekDays(int days)
        {
            switch (days)
            {
                case (int)WeekDays.Monday:
                    Console.WriteLine("Monday");
                    break;
                case (int)WeekDays.Tuesday:
                    Console.WriteLine("Tuesday");
                    break;
                case (int)WeekDays.Wednesday:
                    Console.WriteLine("Wednesday");
                    break;
                case (int)WeekDays.Thursday:
                    Console.WriteLine("Thursday");
                    break;
                case (int)WeekDays.Friday:
                    Console.WriteLine("Friday");
                    break;
                case (int)WeekDays.Saturday:
                    Console.WriteLine("Saturday");
                    break;
                case (int)WeekDays.Sunday:
                    Console.WriteLine("Saturday");
                    break;
                    
            }

        }
    }
}
