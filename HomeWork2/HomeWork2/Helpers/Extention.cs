using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace HomeWork2.Helpers
{
    public static class Extention
    {
        public static int CalculateFactorial(this int a)
        {
            int result = 1;
            for (int i = a; i > 0; i--)
            {
                result = result * i;
            }
            return result;
        }
    }
}
