using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_multi_threading
{
    public static class Semaphore
    {
        static SemaphoreSlim semaphoreSlim = new SemaphoreSlim(3);
        public static void Start()
        {
            for (int i = 1; i <= 5; i++)
            {
                new Thread(() => method(i)).Start();
                Thread.Sleep(100);
            }
        }

        private static void method(int i)
        {
            Console.WriteLine($"Thread nr. {i} is ready");
            semaphoreSlim.Wait();
            Console.WriteLine($"Thread nr. {i} is inside");
            Thread.Sleep(1000);
            semaphoreSlim.Release();
            Console.WriteLine($"Thread nr. {i} is outside");

        }

    }
}
