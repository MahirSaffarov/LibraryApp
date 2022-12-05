using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Models
{
    public class Eagle : Bird
    {
        public string Color { get; set; }
        public int Salam { get; set; }
        public int Sagol { get; set; }
        public int Necesen { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle: Eagle is eating");
        }
    }
}
