using System;

namespace RepTaskDelegate
{
    internal static class Program
    {
        private delegate int Calculator(int number1, int number2);
        private static void Main()
        {
            Calculator add = null;
            add = Addition;
            add += delegate(int a, int b) { return a + b; };
            if (add != null)
                Console.WriteLine(add(1,5));
            Console.WriteLine(add?.Invoke(1, 5));
            Console.ReadLine();
        }

        private static int Addition(int a, int b) => a + b;
    }
}
