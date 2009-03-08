using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DistilledB.EulerWell.Mathematics;
using NUnit.Framework;

namespace DistilledB.EulerWell.Mathematics {
  [TestFixture]
  public class NumberTheoryTest
  {
    [Test]
    public void TestTrialDivisionPrimalityAccuracy()
    {
      // Simpler numbers.
      Assert.IsTrue(NumberTheory.IsPrimeWithNaiveTrialDivision(2));
      Assert.IsTrue(NumberTheory.IsPrimeWithNaiveTrialDivision(5));

      // Number that's an odd perfect square and with no other factors.
      Assert.IsFalse(NumberTheory.IsPrimeWithNaiveTrialDivision(49));

      // Larger numbers.
      Assert.IsFalse(NumberTheory.IsPrimeWithNaiveTrialDivision(100001));
      Assert.IsFalse(NumberTheory.IsPrimeWithNaiveTrialDivision(104728));
      Assert.IsTrue(NumberTheory.IsPrimeWithNaiveTrialDivision(104729));
      Assert.IsFalse(NumberTheory.IsPrimeWithNaiveTrialDivision(104730));

      // 2^31 - 1, the limit of Int32, is also prime.
      Assert.IsTrue(NumberTheory.IsPrimeWithNaiveTrialDivision(Int32.MaxValue));
    }
  }
}