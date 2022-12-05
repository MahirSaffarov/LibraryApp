using System;
using System.Collections.Generic;
using System.Text;

namespace kelvin__and_celsius.Models
{
    public class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double celsius)
        {
            Degree = celsius;
        }
    }
}
