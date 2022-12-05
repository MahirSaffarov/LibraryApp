using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    public class Factorial
    {
        public void CalculateFactorial()    
        {
            int num = 1;
            Console.WriteLine("Enter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
            if(x > 0)
                {
                for (int i = x; i > 0; i--)
                {
                    num *= i;
                }
                Console.WriteLine(num);
                }
                else if (x == 0 || x == 1)
                {
                    Console.WriteLine("Factorial: 1");
                }
                else
                {
                    Console.WriteLine("Enter a correct number ");
                }
            }
        }
    }

