using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_Thread_without_params
{
    class Program
    {
        static void Method()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"\t\t\t{i} - Hello in thread");
            }
        }
        static void Main(string[] args)
        {
            //ThreadStart threadstart = new ThreadStart(Method);
            Thread thread = new Thread(Method);

            thread.Start();
            //Method(); // freeze

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i + " - Hello in main");
            }
        }
    }
}
