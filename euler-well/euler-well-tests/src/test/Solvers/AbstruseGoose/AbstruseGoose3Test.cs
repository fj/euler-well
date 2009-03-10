using System;
using System.Linq;
using DistilledB.EulerWell.Solvers.AbstruseGoose;
using NUnit.Framework;
using DistilledB.EulerWell.Extensions;

namespace DistilledB.EulerWell.Solvers.AbstruseGoose {
  public class AbstruseGoose3Test : ProblemTestHarness<AbstruseGoose3Solver, string> {
    [Test]
    public override void TestExpectedEulerWellSolution() {
      foreach (var s in ProblemSolver.Strategies) {
        Assert.AreEqual("73939133", s());
      }
    }
  }
}