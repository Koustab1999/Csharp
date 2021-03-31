using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo1
{
    class Person
    {
        protected string name;
        protected int age;



        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void printPerson()
        {
            Console.WriteLine("Name   :" + name);
            Console.WriteLine("Age    :" + age);



        }
    }



    class Staff : Person
    {
        protected int staff_id;
        protected long staff_salary;



        public Staff(int staff_id, long staff_salary, string name, int age) : base(name, age)



        {
            this.staff_id = staff_id;
            this.staff_salary = staff_salary;
        }



        public void PrintStaff()
        {
            Console.WriteLine("Staff-id     :" + staff_id);
            base.printPerson();
            Console.WriteLine("Staff-salary :" + staff_salary);



        }
        class Student : Person
        {
            protected int rollno;
            protected double fees;



            public Student(int rollno, double fees, string name, int age) : base(name, age)
            {
                this.rollno = rollno;
                this.fees = fees;
            }



            public void PrintStudent()
            {
                Console.WriteLine("Student-Rollno    :" + rollno);
                base.printPerson();
                Console.WriteLine("Student-fess      :" + fees);




            }
        }
        class HierarchicalDemo
        {
            static void Main()
            {
                Student s1 = new Student(101, 20000, "anusha", 20);
                Staff s2 = new Staff(1001, 30000, "M.anusha", 22);



                s1.PrintStudent();
                s2.PrintStaff();



                Console.ReadKey();
            }
        }
    }
}