using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _07_Thread_priority
{
    /* Thread Priorities:
        ■ Highest 
        ■ AboveNormal 
        ■ Normal (default)
        ■ BelowNormal 
        ■ Lowest
    */
    class Program
    {
        static void Main(string[] args)
        {
            ParameterizedThreadStart ts = new ParameterizedThreadStart(Method);

            Thread t1 = new Thread(ts);
            Thread t2 = new Thread(ts);

            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start((object)"t1: Lowest");
            t2.Start((object)"\t\t\tt2: Highest");
             
            Console.ReadKey();
        }
        static void Method(object str)
        {
            string text = (string)str;
            for (int i = 0; i < 20_000; i++)
            {
                Console.WriteLine("{0} #{1}", text, i.ToString());
            }
        }
    }
}
