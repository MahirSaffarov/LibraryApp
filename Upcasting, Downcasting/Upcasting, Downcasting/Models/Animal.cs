using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting__Downcasting.Models

{
    public abstract class Animal 
    {
        public string Name { get; set; }
        public abstract void Eat();
    }
}
