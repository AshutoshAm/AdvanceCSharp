using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    //a multicast del is a del that has ref to more than one functions
    //used in observer pattern where publish / subscribe patterns works 
    public delegate void SampleDel();
    class MultiCast
    {
        public static void Example()
        {
            SampleDel del1 = new SampleDel(SampleMethod1);
            SampleDel del2 = new SampleDel(SampleMethod2);
            SampleDel del3 = del1 + del2;
       
            del3.Invoke();
            //it invoke both method
        }

        public static void SampleMethod1()
        {
            Console.WriteLine("This is sample method 1");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("This is sample method 2");
        }
    }
}
