using System;
using Upcasting__Downcasting.Models;

namespace Upcasting__Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {

            Eagle eagle1 = new Eagle();
            eagle1.Name = "Eagle: I am a Eagle";
            Console.WriteLine(eagle1.Name);
            eagle1.Color = "Eagle: Black";
            Console.WriteLine(eagle1.Color);
            eagle1.Eat()

            Console.WriteLine();

            Shark shark1 = new Shark();
            shark1.Name = "Shark: I am a Shark";
            Console.WriteLine(shark1.Name);
            shark1.Teeth = "Shark: 32";
            Console.WriteLine(shark1.Teeth);
            shark1.Eat();

            Console.WriteLine();

            Animal eagle2 = new Eagle();
            eagle2.Name = "Eagle: I am a Eagle";
            Console.WriteLine(eagle1.Name);
            eagle2.Eat();


        }
    }
}
