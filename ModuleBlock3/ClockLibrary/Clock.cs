using System.Threading;

namespace ClockLibrary
{
    public class Clock
    {
        public delegate void Notifier();
        public void StartTimer(Notifier logic)
        {
            for (var i = 0; i <= 600; i++)
            {
                logic?.Invoke();
                Thread.Sleep(1000);
            }
        }
    }
}
