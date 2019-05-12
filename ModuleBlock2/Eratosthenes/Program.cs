using System;
using System.Collections.Generic;
using System.Linq;
using Eratosthenes.Enums;

namespace Eratosthenes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if(!args.Any() || !int.TryParse(args[0], out var size))
                return;
            var primNumbers = Eratosthenes(size);
            for (var i = 0; i < size; i++)
            {
                Console.Write($"{i}: {primNumbers[i]} ");
                if ((i+1) % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
            var extractedPrimNumbers = ExtractPrimNumbers(primNumbers);
            for (var i = 0; i < extractedPrimNumbers.Length; i++)
            {
                Console.Write($"{extractedPrimNumbers[i]} ");
                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            var writtenLines = 0;
            foreach (var number in ExtractPrimNumbersAsList(primNumbers))
            {
                Console.Write($"{number} ");
                writtenLines++;
                if (writtenLines % 10 == 0)
                    Console.WriteLine();
            }
            Console.ReadLine();

        }

        private static List<int> ExtractPrimNumbersAsList(IReadOnlyList<PrimType> primes)
        {
            var extractedPrimes = new List<int>();
            for (var k = 0; k < primes.Count; k++)
            {
                if (primes[k] == PrimType.Prim)
                    extractedPrimes.Add(k);
            }

            return extractedPrimes;
        }

        private static int[] ExtractPrimNumbers(IReadOnlyList<PrimType> primes)
        {
            var nrPrimes = primes.Count(a => a == PrimType.Prim);
            var extractedPrimes = new int[nrPrimes];
            var p = 0;
            for (var k = 0; k < primes.Count; k++)
            {
                if (primes[k] == PrimType.Prim)
                    extractedPrimes[p++] = k;
            }

            return extractedPrimes;
        }

        private static PrimType[] Eratosthenes(int n)
        {
            //Every number is generated as Prime.
            var filter = new PrimType[n];
            //do it until the square of the current number is equal to n
            for (var number1 = 2; number1*number1 < n; number1++)
            {
                //You already know that it isn't a prim
                if (filter[number1] != PrimType.Prim) continue;
                //if it is a prim we will mark the multiplied numbers of the current number as NotPrim
                //We do it the second times the first number are equal to n
                for (var number2 = 2; number1*number2 < n;number2++)
                    filter[number1*number2] = PrimType.NotPrim;
            }
            return filter;
        }
    }
}
