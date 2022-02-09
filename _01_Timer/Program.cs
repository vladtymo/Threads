using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _01_Timer
{
    class Program
    {
        public static void TimerMethod(object a)
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine($"Thread [{th.ManagedThreadId}] {(th.IsBackground ? "Secondary" : "Primary")}");
            Console.WriteLine("Hello in timer");
        }
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            Console.WriteLine($"Thread [{th.ManagedThreadId}] {(th.IsBackground ? "Secondary" : "Primary")}");

            //TimerCallback callback = new TimerCallback(TimerMethod);
            Timer timer = new Timer(TimerMethod);
            // 1st - due time, 2st - period
            timer.Change(2000, 500);

            Console.ReadKey();
            timer.Dispose();
        }
    }
}
