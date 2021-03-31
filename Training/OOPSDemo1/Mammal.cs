using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace OOPSDemo1
{ 
    public class Mammal
    {
        private int age;
        public Mammal(int age)
        {
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void Sleep()
        {
            Console.WriteLine("i am sleeping");
        }
    }
}

