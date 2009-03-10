using System;
using System.Linq;
using DistilledB.EulerWell.Solvers.AbstruseGoose;
using DistilledB.EulerWell.Solvers.ProjectEuler;
using NUnit.Framework;
using DistilledB.EulerWell.Extensions;

namespace DistilledB.EulerWell.Solvers.AbstruseGoose {
  public class AbstruseGoose1Test : ProblemTestHarness<AbstruseGoose1Solver, string>
  {
    [Test]
    public override void TestExpectedEulerWellSolution()
    {
      foreach (var s in ProblemSolver.Strategies)
      {
        Assert.AreEqual("", s());
      }
    }
  }
}