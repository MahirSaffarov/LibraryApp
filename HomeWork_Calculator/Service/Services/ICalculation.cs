using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public interface ICalculation
    {
        void Addition(int num1, int num2);
        void Subtraction(int num1, int num2);
        void Multiplication(int num1, int num2);
        void Division(int num1, int num2);
    }
}
