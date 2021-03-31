using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPSDemo1
{ 
    public class Dog : Mammal
    {
        private string breed;
        public Dog(int age, String breed) : base(age)
        {
            this.breed = breed;
        }
        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public void WagTail()
        {
            Console.WriteLine("tail wagging.......");
        }
    }
}