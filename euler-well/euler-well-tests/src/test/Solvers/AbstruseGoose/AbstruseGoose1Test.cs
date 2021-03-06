using System;
using System.Linq;
using DistilledB.EulerWell.Solvers.AbstruseGoose;
using NUnit.Framework;
using DistilledB.EulerWell.Extensions;

namespace DistilledB.EulerWell.Solvers.AbstruseGoose {
  public class AbstruseGoose1Test : ProblemTestHarness<AbstruseGoose1Solver, string> {
    [Test]
    public override void TestExpectedEulerWellSolution() {
      foreach (var s in ProblemSolver.Strategies) {
        Assert.AreEqual("7427466391", s());
      }
    }
  }
}