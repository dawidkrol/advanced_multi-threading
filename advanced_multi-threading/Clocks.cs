using System.Timers;

namespace advanced_multi_threading
{
    public static class Clocks
    {
        public static System.Timers.Timer _timer = new();
        public static void Method()
        {
            _timer.Interval = 1000;
            _timer.Elapsed += _timer_Elapsed;
        }

        private static void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Tic-Tac");
        }
    }
}
