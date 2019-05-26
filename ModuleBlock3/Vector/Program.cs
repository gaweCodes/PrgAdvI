using System;

namespace Vector
{
    internal class Program
    {
        private static void Main()
        {
            var v1 = new Vector(1,2,3);
            var v2 = new Vector(4,5,6);
            Console.WriteLine((v1 + v2).ToString());
            Console.WriteLine((v1 - v2).ToString());
            Console.WriteLine((v1 * 5).ToString());
            Console.WriteLine((6 * v1).ToString());
            Console.WriteLine((v1 * v2).ToString());
            Console.WriteLine((double)v1);
            var v3 = new Vector();
            Console.WriteLine((v3 = 5).ToString());
            for (var i = 1; i <= 3; i++)
                v2[i] = i;
            Console.WriteLine(v1 == v2);
            Console.WriteLine(v1 != v2);
            Console.WriteLine(v1.Equals(v2));
            Console.Read();
        }
    }
}
