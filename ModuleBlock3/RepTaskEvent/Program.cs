using System;

namespace RepTaskEvent
{
    internal static class Program
    {
        private static void Main()
        {
            var clock = new DelegateClock();
            clock.OnTick += SayTick;
            clock.OnTick += SayTack;
            clock.StartTimer();
        }

        private static void SayTick(object sender, EventArgs e) => Console.WriteLine("Tick");
        private static void SayTack(object sender, EventArgs e) => Console.WriteLine("Tack");
    }
}
;