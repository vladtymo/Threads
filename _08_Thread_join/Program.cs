using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_Thread_join
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart TS = new ThreadStart(Method);
            Thread T = new Thread(TS);
            Console.WriteLine("Thread is going to start...");           

            T.Start();
            Thread.Sleep(200);
            Console.WriteLine("Waiting for thread ending...");

            //waiting
            T.Join();
            Console.WriteLine("Program was ended.");
        }
        static void Method()
        {
            Console.WriteLine("Thread is working...");
            Thread.Sleep(3000);
            Console.WriteLine("Thread was ended.");
        }
    }
}