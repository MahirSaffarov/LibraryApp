using Service;
using Service.Services;
using System;

namespace HomeWork_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please choose operation(1-4)");
            //Console.WriteLine("1.Addition");
            //Console.WriteLine("2.Subtraction");
            //Console.WriteLine("3.Multiplication");
            //Console.WriteLine("4.Division");
            //Console.Write("Operation: ");

            //string operation = Console.ReadLine();
            //double result;

            //ICalculation calculator = new Calculation();
            //calculator.Num1();
            //double num1 = Convert.ToInt32(Console.ReadLine());

            //calculator.Num2();
            //double num2 = Convert.ToInt32(Console.ReadLine());




            //if (operation == "+")
            //    {
            //        result = num1 + num2;
            //        Console.WriteLine($"Your answer: " + result);
            //}
            //    else if (operation == "-")
            //    {
            //        result = num1 - num2;
            //        Console.WriteLine($"Your answer: "+result);
            //    }
            //    else if (operation == "*")
            //    {
            //        result = num1 * num2;
            //        Console.WriteLine($"Your answer: "+result);
            //    }
            //    else if (operation == "/")
            //    {
            //        result = num1 / num2;
            //        Console.WriteLine($"Your answer: "+result);
            //    }
            //    else
            //        Console.WriteLine("Please enter correct operation");



            Console.WriteLine("Please choose operation");
            Console.WriteLine("Addition(+): ");
            Console.WriteLine("Subtraction(-): ");
            Console.WriteLine("Multiplication(*): ");
            Console.WriteLine("Division(/): ");
            Console.Write("Operation: ");

            string operation;
            operation = Console.ReadLine();

            if (operation == "+")
            {
                Console.Write("Enter number one: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number two: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                ICalculation calculator = new Calculation();
                calculator.Addition(num1, num2);

            }
            else if (operation == "-")
            {
                Console.Write("Enter number one: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number two: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                ICalculation calculator = new Calculation();
                calculator.Subtraction(num1, num2);
            }
            else if (operation == "*")
            {
                Console.Write("Enter number one: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number two: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                ICalculation calculator = new Calculation();
                calculator.Multiplication(num1, num2);
            }
            else if (operation == "/")
            {
                Console.Write("Enter number one: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter number two: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                ICalculation calculator = new Calculation();
                calculator.Division(num1, num2);

            }
            else
            {
                Console.WriteLine("Please select correct operation");
                
            }
        }
    }
}


