using System;

namespace _1._2_CounterLib
{
    public class CounterEventArgs : EventArgs
    {
        public CounterEventArgs(int value) => Value = value;
        public int Value { get; set; }
    }
}
