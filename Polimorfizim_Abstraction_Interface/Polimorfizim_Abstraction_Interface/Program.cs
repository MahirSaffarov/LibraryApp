using Polimorfizim_Abstraction_Interface.Models;
using System;
using Math;
using Service.Services.Interfaces;
using Service.Services;

namespace Polimorfizim_Abstraction_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Console.WriteLine(car.Name);
            //Console.WriteLine(car.Person);
            //car.Person = "12424";

            //Factorial factorial = new Factorial();
            //factorial.CalculateFactorial();

            //Cat cat = new Cat();
            //cat.GetSound();

            //Bird bird = new Bird();
            //bird.GetSound();

            //Animal animal = new Animal();
            //animal.GetSound();

            //Student stu = new Student()
            //{
            //    Name = "Mahir",
            //    Surname = "Safarov",
            //    Age = 20
            //};

            //Console.WriteLine(GetStudent(stu, 21));

            //Student stu = new Student();
            //stu.Test1();
            //Employee emp = new Employee();
            //emp.Test1();

            //User user = new User();
            //user.Age();

            IAccountService reg = new AccountService();
            reg.Register("asd", "da");
        }

        //public static Student GetStudent(Student studen, int age)
        //{
        //    studen.Age = age;
        //    return studen;
        //}    
    }
}
