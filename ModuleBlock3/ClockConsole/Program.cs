using System;
using ClockLibrary;

namespace ClockConsole
{
    internal class Program
    {
        private static void Main()
        {
            var clock = new Clock();
            var n = new Clock.Notifier(SayTack);
            clock.StartTimer(n);
        }
        private static void SayTack()
        {
            Console.WriteLine("Tick");
        }
    }
}
