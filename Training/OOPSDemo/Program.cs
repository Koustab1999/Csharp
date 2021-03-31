using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first dog's name:");
            String dogname = Console.ReadLine();
            Console.WriteLine("Enter the dog breed: ");
            String dogBreed = Console.ReadLine();
            Dog firstdog = new Dog(dogname, dogBreed);
            Dog seconddog = new Dog();
            firstdog.sayBau();
            seconddog.sayBau();
            Console.WriteLine("Enter second dog's name:");
            dogname = Console.ReadLine();

            Console.WriteLine("Enter the second dog breed: ");
            dogBreed = Console.ReadLine();
            seconddog.Name = dogname;
            seconddog.Breed = dogBreed;
            Console.WriteLine("The name is :" + seconddog.Name);
            Console.WriteLine("The breed is: " + seconddog.Breed);



            Console.ReadKey();
        }
    }
}
