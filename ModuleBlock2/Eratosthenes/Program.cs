using System;
using System.Collections.Generic;
using Eratosthenes.Enums;

namespace Eratosthenes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int maxSize = 100;

            if (args.Length < 1)
            {
                Console.WriteLine("There was no argument!");
                return;
            }

            if (!int.TryParse(args[0], out var enteredSize))
            {
                Console.WriteLine("It wasn't possible to parse your argument to a integer.");
                return;
            }

            if (enteredSize > maxSize)
            {
                Console.WriteLine($"You entered size is bigger than the max size of {maxSize}");
                return;
            }

            var x = Eratosthenes(enteredSize);
        }

        private static IEnumerable<PrimeType> Eratosthenes(int maxPrime)
        {
            var primes = new PrimeType[maxPrime];
            for (var p = 2; p * p < maxPrime; p++)
            {
                if (primes[p] == PrimeType.NotPrime) continue;
                for (var k = 2; p * k < maxPrime; k++)
                    primes[p * k] = PrimeType.NotPrime;
            }
            return primes;
        }
    }
}
