using System;
using Integrator.Interfaces;

namespace Integrator
{
    internal class Program
    {
        private const int Steps = 100;
        private const double Eps = 1E-10;

        private static void Main()
        {
            IFunction f1 = new LineFunction();
            Console.WriteLine(f1.GetType().Name + ":" + Integrator.Integrate(f1, 0, 10, Steps));
            IFunction f2 = new SquareFunction();
            Console.WriteLine(f2.GetType().Name + ":" + Integrator.Integrate(f2, 0, 10, Steps));
            Console.WriteLine(f2.GetType().Name + ":" + Integrator.Integrate(f2, 0, 10, Eps));
            Console.ReadLine();
        }
    }

    public class LineFunction : IFunction
    {
        public double F(double x)
        {
            return x;
        }
    }

    public class SquareFunction : IFunction
    {
        public double F(double x)
        {
            return x * x;
        }
    }
}
