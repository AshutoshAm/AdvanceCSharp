using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //predicate delegate methods take one input parameter or more and return a boolean - true or false.
    class PredicateDelegates
    {
        static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        static void Example()
        {
            Predicate<string> isUpper = IsUpperCase;

            bool result = isUpper("hello world!!");

            Console.WriteLine(result);


            //anonymous
            Predicate<string> isUpperdel = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result2 = isUpper("hello world!!");
        }
    }
}
