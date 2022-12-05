using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class Animal
    {
        public virtual void GetSound()
        {
            Console.WriteLine("Animal sound");
        }
        public void Eat()
        {
            Console.WriteLine("Animal eating");
        }
        public void Eat(string t)
        {
            Console.WriteLine("Animal eating");
        }
        public void Eat(string t, string w)
        {
            Console.WriteLine(t + " " + w);
        }
        
    }
}
