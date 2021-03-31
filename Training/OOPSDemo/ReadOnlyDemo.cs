using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class ReadOnlyDemo
    {
        private readonly String name = "Gosling";
        private readonly string location;
        private readonly int age;

        public ReadOnlyDemo()
        {
            // name = "Gosling";
            location = "Blr";
            age = 25;
        }
        void setDetails()
        {
            /* name = "Gosling";
             location = "Blr";
             age = 25;*/
        }
        void display()
        {
            Console.WriteLine("Hello {0}, aged {1}, from {2} ", name, age, location);
        }
        static void Main()

        {
            ReadOnlyDemo r1 = new ReadOnlyDemo();
            r1.display();
        }

    }
}
