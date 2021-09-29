using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //its improve performance 
    //lambda action func predicate 
    //https://www.youtube.com/watch?v=8o0O-vBS8W0
    public class Anonymous
    {
        public delegate void Print(int value);

        static void Example()
        {

            Print print2 =  Printmethod;
            print2.Invoke(5);

           Print print = delegate (int val) {
                Console.WriteLine("Inside Anonymous method. Value: {0}", val);
            };

            print(100);
        }
         static void Printmethod(int val)
        {
            Console.WriteLine("Inside  method. Value: {0}", val);

        }
    }
}
