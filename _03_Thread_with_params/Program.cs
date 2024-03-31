using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03_Thread_with_params
{
    class Program
    {
        static void ThreadFunk(object a)
        {
            string ID = (string)a;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(ID);
                //Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("24 line");

            //ParameterizedThreadStart threadstart = new ParameterizedThreadStart(ThreadFunk);
            var thread1 = new Thread(ThreadFunk);
            thread1.Start((object)"One");

            Console.WriteLine("28 line");

            Thread thread2 = new Thread(ThreadFunk);
            thread2.Start("\t\tTwo");

            Console.WriteLine("33 line");

            Console.WriteLine("End!");
        }
    }
}