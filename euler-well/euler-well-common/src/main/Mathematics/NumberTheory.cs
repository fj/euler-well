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
    public static bool IsPrimeWithNaiveTrialDivision(long n)
    {
      // An even number is prime only if that number is 2.
      if (n % 2 == 0) return n == 2;

      // If this number had a factor greater than sqrt(n), then it must have had a factor less than sqrt(n), and we
      // would have found it already.
      var limit = System.Math.Sqrt(n);

      var isComposite = false;
      var x = 3;

      // Test each factor up to and including the limit.
      for (; x <= limit && !isComposite; x += 2)
      {
        // If it's composite, we're all finished.
        isComposite = n % x == 0;
      }

      return !isComposite;
    }
  }
}