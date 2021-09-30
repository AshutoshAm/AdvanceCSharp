using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
   

    public class Event2
    {
        public static void Example()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.ProcessCompleted += bl_ProcessCompleted2; // register with an event
            bl.StartProcess();
        }

        // event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
        public static void bl_ProcessCompleted2()
        {
            Console.WriteLine("Process Completed!");
        }
    }


    public delegate void Notify();  // delegate

    public class ProcessBusinessLogic
    {
        public event Notify  ProcessCompleted; // event

        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            // some code here..
           // OnProcessCompleted();
            ProcessCompleted?.Invoke();

        }


        protected  void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
