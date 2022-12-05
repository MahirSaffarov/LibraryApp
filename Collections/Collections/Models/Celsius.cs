using System;
using System.Collections.Generic;
using System.Text;

namespace Collections.Models
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double degree)
        {
            Degree = degree;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            Kelvin kelvin = new Kelvin(celsius.Degree + 273);
            return kelvin;
        }
    }
}
