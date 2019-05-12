using System;
using Integrator.Interfaces;

namespace Integrator
{
    internal class Integrator
    {
        public static double Integrate(IFunction func, double start, double end, int step)
        {
            var d = (end - start) / step;
            var sum = (func.F(start) + func.F(end)) / 2;
            for (var i = 1; i < step; i++)
                sum += func.F(start + i * d);
            return d * sum;
        }


        public static double Integrate(IFunction func, double start, double end, double eps)
        {
            var steps = 1;
            double err, v2, v1 = Integrate(func, start, end, steps);
            do
            {
                steps *= 2;
                v2 = Integrate(func, start, end, steps);
                err = Math.Abs(v2 - v1);
                v1 = v2;
            } while (err > eps);

            return v2;
        }
    }
}
