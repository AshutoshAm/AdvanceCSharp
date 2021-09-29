using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //same as func but Action delegate doesn't return a value. 
    class Actiondelegate
    {
        static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }

        static void Example()
        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(10);
        }
    }
}
