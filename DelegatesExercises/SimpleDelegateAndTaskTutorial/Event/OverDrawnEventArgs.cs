using System;

namespace SimpleDelegateAndTaskTutorial.Event
{
    public class OverDrawnEventArgs : EventArgs
    {
        public double Balance { get; }

        public OverDrawnEventArgs(double balance)
        {
            Balance = balance;
        }
    }
}
