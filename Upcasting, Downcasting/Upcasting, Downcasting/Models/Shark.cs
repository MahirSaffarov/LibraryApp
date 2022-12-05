using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Models
{
    public class Shark : Fish
    {
        public string Teeth { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark: Shark is eating");
        }
    }
}
