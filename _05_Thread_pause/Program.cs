using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_Thread_pause
{
    class Program
    {
        static void Method()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(ts);
            t.Start(); // Запуск потока.
            Console.WriteLine("Press any key to pause thread...");
            
            Console.ReadKey();
            t.Suspend(); // Приостановка потока.
            Console.WriteLine("Thread is stoped!");
            Console.WriteLine("Press any key to resume thread...");
           
            Console.ReadKey();
            t.Resume(); // Возобновление работы.
        }
    }
}