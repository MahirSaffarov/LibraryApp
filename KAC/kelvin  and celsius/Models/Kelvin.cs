using System;
using System.Collections.Generic;
using System.Text;

namespace kelvin__and_celsius.Models
{
    public class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double kelvin)
        {
            Degree = kelvin;
        }
        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree + 273);
        }
    }
}
