using System;

namespace Delegates
{

    //delegates is pointer of a function or its a type safe function pointer 
    //delegates holds the ref od method and call the method 
    //delegates is a representative to comunicate between two parties
    //delegates is used for callbacks

    class Program
    {
        public delegate void Add();
        static void Main(string[] args)
        {



            //this is pointer of function definition
            Console.WriteLine("Hello World!");

            Events.Example();
            //Second.SecondExample();
            Console.ReadKey();
            //Add ad = new Add(Addmethod);

            //ad = Addmethod2;

            //ad.Invoke();

            //Add ad2 = new Add(Addmethod2);
            // ad2.Invoke();


            //callback
            // Oprations op = new Oprations();
            // op.WriteToTextFile(Callbackmethod);

            //Second.SecondExample();

            //MultiCast.Example();

            // Event2.Example();

        }

        public static void Addmethod()
        {
            Console.WriteLine("Output from add method");
        }
        public static void Addmethod2()
        {


            Console.WriteLine("Output from add 2  method");
        }
        public static void Callbackmethod(int i)
        {
            Console.WriteLine("Working on {0}", i);
        }
    }
    public class Oprations
    {
        public delegate void CallBackDelegate(int position);
        public void WriteToTextFile(CallBackDelegate cbd)
        {
            for (int i = 0; i <= 10000; i++)
            {
                cbd(i);
               
            }

        }
    }
}
