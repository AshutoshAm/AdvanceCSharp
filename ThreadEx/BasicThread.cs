using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ThreadEx
{
    //Threads allows a program to operate more efficiently by doing multiple things at the same time.

  //  Threads can be used to perform complicated tasks in the background without interrupting the main program.
    class BasicThread
    {
        public static void Example()
        {
            Thread th1 = new Thread(Func1);
            Thread th2 = new Thread(Func2);

            th1.Start();
            th2.Start();


        }
        public static void Func1()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Func 1 "+i);
            }
        }
        public static void Func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Func 2 " + i);
            }
        }

    }
}
