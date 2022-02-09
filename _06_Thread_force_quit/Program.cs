using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06_Thread_force_quit
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.IsBackground = true;
            t.Start();

            Console.WriteLine("Press any key to force quit thread...");

            Console.ReadKey();
            t.Abort(); 
        }
        static void Method()
        {
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);

                    Console.WriteLine(i.ToString());
                }
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("End Thread Work");
            }
        }
    }
}
