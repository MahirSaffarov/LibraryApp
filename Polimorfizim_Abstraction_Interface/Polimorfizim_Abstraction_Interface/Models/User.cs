using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfizim_Abstraction_Interface.Models
{
    class User : IUser
    {
        public void Age()
        {
            Console.WriteLine(20);
        }

        public void Name()
        {
            Console.WriteLine("Mahir");
        }

        public void Surname()
        {
            Console.WriteLine("Safarov");
        }
    }
}
