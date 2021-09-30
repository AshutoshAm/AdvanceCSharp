using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ThreadEx
{
    class TaskReturn
    {
       public static void Example()
        {
            Console.WriteLine($"Main Thread Started");

   
            Task<double> task2 = Task.Run(() =>
            {
                return CalculateSum(10);
            });


            Console.WriteLine($"Sum is : {task2.Result}");
            Console.WriteLine($"Main Thread Completed");
            Console.ReadKey();
        }
        static double CalculateSum(int num)
        {
            double sum = 0;
            for (int count = 1; count <= num; count++)
            {
                sum += count;
            }
            return sum;
        }
    }
}
