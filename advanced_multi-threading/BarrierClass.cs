using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_multi_threading
{
    public static class BarrierClass
    {
        static Barrier _barrier = new Barrier(3);

        public static void CounterWithBearer()
        {
            for (int i = 0; i < 4; i++)
            {
                _barrier.SignalAndWait();
                Console.WriteLine(i);
            }
        }
        public static void CounterWithoutBearer()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
