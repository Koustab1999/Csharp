using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo
{
    class User
    {
        private string name;    // properties
        private string location;   // properties
        private string desig;   // properties
        private int age;        // properties
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Desig { get { return desig.ToUpper(); } set { desig = value; } }
        public int Age { get { return age; } set { if (value > 20) age = value; } }

        public static void Main()
        {
            User u = new User();
            u.Name = "Steven";
            u.Location = "Hyderabad";

            u.Desig = "Developer";
            u.Age = 19;

            Console.WriteLine(u.Name+ " "+ u.Location);
            Console.WriteLine(u.Desig + " " + u.Age);
            Console.ReadKey();
           
        }
    }
}
