using System;
using System.Threading;

namespace RepTaskEvent
{
    public class DelegateClock
    {
        public event EventHandler OnTick;

        public void StartTimer()
        {
            const int seconds = 5;
            var i = 0;
            while (i < seconds)
            {
                Thread.Sleep(1000);
                OnTick?.Invoke(this, new EventArgs());
                i++;
            }
        }
    }
}
