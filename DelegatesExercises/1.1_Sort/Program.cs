using System;
using System.Diagnostics;

namespace _1._1_Sort
{
    public delegate int Comparer(object x, object y);
    internal class Fraction
    {
        public int A, B;
        public Fraction(int a, int b)
        {
            A = a;
            B = b;
        }
        public override string ToString()
        {
            return A + "/" + B;
        }
    }
    internal class Program
    {
        private static int CompareFraction(object x, object y)
        {
            var f1 = (Fraction) x;
            var f2 = (Fraction) y;
            var fraction1 = (float) f1.A / f1.B;
            var fraction2 = (float) f2.A / f2.B;
            if (fraction1 < fraction2) return -1;
            return fraction1 > fraction2 ? 1 : 0;
        }
        private static int CompareString(object x, object y)
        {
            return ((string) x).CompareTo(y);
        }
        private static void Sort(object[] a, Comparer compare)
        {
            Debug.Assert(compare != null && compare.GetInvocationList().Length == 1, "Genau eine Vergleichsmethode.");

            for (var i = 0; i < a.Length - 1; i++)
            {
                var min = i;
                for (var j = i + 1; j < a.Length; j++)
                    if (compare(a[j], a[min]) < 0) min = j;

                if (min == i) continue;
                var x = a[i];
                a[i] = a[min];
                a[min] = x;
            }
        }
        private static void Main()
        {
            object[] a = { new Fraction(1, 2), new Fraction(3, 4), new Fraction(4, 8), new Fraction(8, 3) };
            object[] b = {"pears", "apples", "oranges", "bananas", "plums"};

            Sort(a, CompareFraction);
            foreach (var f in a) Console.Write(f + " ");
            Console.WriteLine();

            Sort(b, CompareString);
            foreach (string s in b) Console.Write(s + " ");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
