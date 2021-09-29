using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //Func is generic delegate types  , so that we don't need to define custom delegates manually in most cases.
    //It has zero or more input parameters and one out parameter. The last parameter is considered as an out parameter.
    class Func
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static void Example()
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);

            //Example: Func with Anonymous Method


            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };
        }
    }
}
