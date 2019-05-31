using System;
using ClockLibrary;

namespace ClockConsoleDelegate
{
    internal class Program
    {
        private static void Main()
        {
            var clock = new Clock();
            Clock.Notifier sayTack = SayTack;
            clock.StartTimer(sayTack);
        }
        private static void SayTack()
        {
            Console.WriteLine("Tack");
        }
    }
}
