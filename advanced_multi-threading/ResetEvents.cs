using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_multi_threading
{
    public static class ResetEvents
    {
        //Wpuszcza tylko jeden wątek
        public static EventWaitHandle a = new EventWaitHandle(false, EventResetMode.AutoReset);
        //Wpuszcza wszytkie wątki
        //public static EventWaitHandle a = new EventWaitHandle(false, EventResetMode.ManualReset);

        public static void Method(int nr)
        {
            a.WaitOne();
            Console.WriteLine($"Thread nr. {nr} is inside");
            a.Reset();
        }
    }
}
