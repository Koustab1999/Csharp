using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPSDemo1
{
    class SingleInheritanceDemo
    {
        static void Main()
        {
            // creating 5 yr old mammal
            Mammal mamal = new Mammal(5);
            Console.WriteLine(mamal.Age);
            mamal.Sleep();



            // create a bull dog,3 yr's old



            Dog dog = new Dog(3, "Bulldog");
            dog.Sleep();
            dog.Age = 4;
            Console.WriteLine("Age:{0}", dog.Age);
            Console.WriteLine("Breed:{0}", dog.Breed);
            dog.WagTail();
            Console.ReadKey();
        }




    }
}