using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advanced_multi_threading
{
    public static class ThreadUnsafe
    {
        public static int i1 = 1;
        public static int i2 = 2;
        public static int i3;  

        public static void Operation()
        {
            if(i2 != 0)
            {
                Console.WriteLine(i2);
                i3 = i1 / i2;
                i2 = 0;
            }
        }
    }
}
