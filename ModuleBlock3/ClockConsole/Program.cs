using System;
using ClockLibrary;

namespace ClockConsole
{
    internal class Program
    {
        private static void Main()
        {
            var clock = new Clock();
            var methodDelegate = new Clock.Notifier(SayTick);
            clock.StartTimer(methodDelegate);
        }
        private static void SayTick()
        {
            Console.WriteLine("Tick");
        }
    }
}
