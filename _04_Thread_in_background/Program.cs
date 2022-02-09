using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _04_Thread_in_background
{
    class Program
    {
        static void Method()
        {
            //Reference of current thread
            Thread ThisThread = Thread.CurrentThread;
            //ID of current thread
            Console.WriteLine("ID of background thread: " + ThisThread.GetHashCode());

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("\t\t\tHello in thread");
                //Delay current thread in milliseconds
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            //Primary and secondary threads
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.IsBackground = false; // default - false
            t.Start();

            Console.WriteLine("ID of primary thread: " + Thread.CurrentThread.GetHashCode());

            Console.ReadKey();
            Console.WriteLine("Main end!");
        }
    }
}
