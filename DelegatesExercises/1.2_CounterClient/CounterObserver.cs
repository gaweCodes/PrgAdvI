using System;
using _1._2_CounterLib;

namespace _1._2_CounterClient
{
    internal class CounterObserver
    {
        private readonly string _name;
        public CounterObserver(string name) =>_name = name;
        public void OnCountValueChanged(Counter c, CounterEventArgs arg)
        {
            Console.WriteLine($"CounterObserver {_name}: Counter changed: Value = {arg.Value}");

        }
    }
}
