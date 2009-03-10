using System;
using System.Collections.Generic;
using System.Linq;
using DistilledB.EulerWell.Extensions;

namespace DistilledB.EulerWell.Mathematics {
  public static class NumberTheory
  {
    /// <summary>
    /// Returns true if specified number has no prime factors other than itself.
    /// </summary>
    /// <remarks>
    /// This method uses naive trial division to test each number in turn, beginning with 2 and then testing all
    /// odd numbers up to the square root of the specified number.
    /// </remarks>
    /// <param name="n">the number to test</param>
    /// <returns></returns>
    public static bool IsPrimeWithNaiveTrialDivision(ulong n)
    {
      // Consider inputs less than 2 to be not prime.
      if (n < 2) return false;

      // An even number is prime only if that number is 2.
      if (n % 2 == 0) return n == 2;

      // If this number had a factor greater than sqrt(n), then it must have had a factor less than sqrt(n), and we
      // would have found it already.
      var limit = Math.Sqrt(n);

      var isComposite = false;
      var x = 3;

      // Test each factor up to and including the limit.
      for (; x <= limit && !isComposite; x += 2)
      {
        // If it's composite, we're all finished.
        isComposite = n % (ulong) x == 0;
      }

      return !isComposite;
    }

    /// <summary>
    /// Finds the first prime in the specified string with the specified number of digits that occurs no later than the maximum number of iterations.
    /// </summary>
    /// <param name="digits">input sequence</param>
    /// <param name="maximumIterations">number of digits from the starting point after which failure should be reported</param>
    /// <param name="primeDigitSize">length of prime to find</param>
    /// <returns>the first prime matching the specifications, or null if no prime was found</returns>
    public static string FindFirstPrime(string digits, int maximumIterations, int primeDigitSize)
    {
      var firstPrime = 0L;
      var q = digits.ContiguousSubsequences(primeDigitSize);
      var size = q.Count();

      for (var i = 0; firstPrime == 0 && i < size; ++i)
      {
        var currentString = new string(q.ElementAt(i).ToArray());
        // Cannot be a number of primeDigitSize.
        if (currentString.StartsWith("0")) continue;

        var parsedString = long.Parse(currentString);

        if (TrialDivisionPrimeFactors(parsedString, 2).Count() == 1)
        {
          firstPrime = parsedString;
        }
      }

      return firstPrime != 0 ? firstPrime.ToString() : null;
    }

    public static IEnumerable<long> TrialDivisionPrimeFactors(long n, long greatestKnownFactor)
    {
      if (greatestKnownFactor < 2) throw new ArgumentException("greatestKnownFactor cannot be less than 2");

      var factors = new List<long>();
      while (n % greatestKnownFactor != 0)
      {
        ++greatestKnownFactor;
      }
      factors.Add(greatestKnownFactor);
      if (n > greatestKnownFactor)
      {
        factors.AddRange(TrialDivisionPrimeFactors(n / greatestKnownFactor, greatestKnownFactor));
      }

      return factors;
    }
  }
}