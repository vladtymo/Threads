namespace _06_force_quit_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            var token = cts.Token;

            bool isPaused = false;

            //ThreadStart ts = new ThreadStart(Method);
            Thread t = new Thread(Method);
            t.IsBackground = false;
            t.Start(token);

            Console.WriteLine("Press any key to force quit thread...");

            Console.ReadKey();

            isPaused = true;

            isPaused = false;
            // 1 - quit thread
            //t.Interrupt();

            // 2 - request thread to be cancelled
            cts.Cancel();
        }
        static void Method(object? obj)
        {
            CancellationToken token = (CancellationToken)obj;
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);

                    token.ThrowIfCancellationRequested();

                    //if (token.IsCancellationRequested)
                    //    throw new OperationCanceledException();

                    Console.WriteLine(i.ToString());
                }
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e.Message);
                //Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("End Thread Work");
            }

            Console.WriteLine("After try catch...");
        }
    }
}