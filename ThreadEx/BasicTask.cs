using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadEx
{
    //https://www.c-sharpcorner.com/blogs/task-vs-thread-differences-in-c-sharp1
    //Task is a lightweight object for managing a parallelizable unit of work. It can be used whenever you want to execute something in parallel.
    class BasicTask
    {
        public static void Example()
        {
            var task1 = new Task(() => SomeWork("Task 1", 1000));
            var task2 = new Task(() => SomeWork("Task 2", 1500));
            var task3 = new Task(() => SomeWork("Task 3", 4000));
            task1.Start();
            task1.Wait();

            task2.Start();
            task3.Start();

            Console.ReadKey();
        }

        static void SomeWork(string id,int sleep)
        {
            Console.WriteLine("{0} task is starting", id);
            Thread.Sleep(sleep);
            Console.WriteLine("{0} task is completed", id);

        }



    }
}
