using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DistilledB.EulerWell.Common;
using DistilledB.EulerWell.Mathematics;

namespace DistilledB.EulerWell.Solvers.AbstruseGoose {
  [Problem(
    Id = "abstruse-goose-3",
    Description = "Find the largest right-truncatable prime.")]
  public class AbstruseGoose3Solver : IProblemSolver<string> {
    public IEnumerable<SolutionStrategy<string>> Strategies {
      get { return new SolutionStrategy<string>[] {DepthFirstSearch}; }
    }

    public string DepthFirstSearch() {
      // Initial population.
      var candidates = new Queue<ulong>();
      foreach (var u in new ulong[] {2, 3, 5, 7}) {
        candidates.Enqueue(u);
      }

      var primes = new List<ulong>();

      while (candidates.Count > 0) {
        var candidate = candidates.Dequeue();
        // If this number isn't prime, stop exploring it.
        if (!NumberTheory.IsPrimeWithNaiveTrialDivision(candidate)) continue;

        // The number was prime. Let's remember this and generate all its successors.
        primes.Add(candidate);
        foreach (var i in GenerateSuccessorPrimes(candidate)) {
          candidates.Enqueue(i);
        }
      }

      // The biggest prime is the one we want.
      return primes.OrderBy(i => i).Last().ToString();
    }

    public IEnumerable<ulong> GenerateSuccessorPrimes(ulong s) {
      // No even number can be a legal terminating digit, nor the number "5".
      var nextPrimes = new List<string>();
      nextPrimes.AddRange(new string[] {"1", "3", "7", "9"});
      return nextPrimes.Select(i => ulong.Parse(s + i));
    }
  }
}