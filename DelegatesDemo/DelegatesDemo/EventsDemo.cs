using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    //publisher class
    class Add
    {
        public delegate void dgOdd();//declare delegate
        public event dgOdd evOdd;//declare event
                                 //dgOdd delegte evodd for event 
                                 //events should always have a delegate
        public void sum()
        {
            int result;
            result = 5 + 4;
            Console.WriteLine(result);
            //check if result is odd no thn raise an event 
            if ((result % 2 != 0) && (evOdd != null))
            {
                evOdd();//raise event
            }

        }

    }
    //subscriber class
    class EventsDemo
    {
        static void Main()
        {
            Add a = new Add();

            a.evOdd += new Add.dgOdd(EventMessage);
            a.sum();
            Console.ReadKey();
        }
        //delegates calls this eventhandler when event raised 
        private static void EventMessage()
        {
            Console.WriteLine("event Fired.....!!!1Result is odd number");
        }
    }
}