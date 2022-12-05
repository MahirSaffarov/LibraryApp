using kelvin__and_celsius.Models;
using System;

namespace kelvin__and_celsius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter celsius temp:  ");
            double d = Convert.ToInt32(Console.ReadLine());
            Celsius celsius = new Celsius(d);
            Kelvin kelvin = celsius;
            Console.WriteLine($"Kelvin:  {kelvin.Degree}");
        }
    }
}
