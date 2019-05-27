using System;
using ClockLibrary;

namespace ClockConsoleDelegate
{
    internal class Program
    {
        private static void Main()
        {
            var clock = new Clock();
            Clock.Notifier n = SayTack;
            clock.StartTimer(n);
        }
        private static void SayTack()
        {
            Console.WriteLine("Tack");
        }
    }
}
