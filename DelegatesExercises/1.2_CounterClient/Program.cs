using System;
using _1._2_CounterLib;

namespace _1._2_CounterClient
{
    internal class Program
    {
        private static void OnCountValueChanged(Counter c, CounterEventArgs arg) =>
            Console.WriteLine($"Counter changed: Value = {arg.Value}");

        [STAThread]
        private static void Main()
        {
            var myCounter = new Counter(10);

            var myObserver1 = new CounterObserver("obs1");
            var myObserver2 = new CounterObserver("obs2");

            myCounter.CountValueChanged += OnCountValueChanged;
            myCounter.CountValueChanged += myObserver1.OnCountValueChanged;
            myCounter.CountValueChanged += myObserver2.OnCountValueChanged;

            myCounter.Increment();
            myCounter.CountValueChanged -= myObserver1.OnCountValueChanged;

            myCounter.Reset(100);
            Console.ReadLine();
        }
    }
}