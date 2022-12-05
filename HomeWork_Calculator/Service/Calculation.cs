using Service.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Calculation : ICalculation
    {
        public void Addition(int num1, int num2)
        {
            Console.WriteLine($"Answer: "+num1 + num2);
        }
        public void Subtraction(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        public void Multiplication(int num1, int num2)
        {
            Console.WriteLine($"Answer: " + num1 * num2);
        }
        public void Division(int num1, int num2)
        {
            Console.WriteLine($"Answer: " + num1 / num2);
        }
    }

}
