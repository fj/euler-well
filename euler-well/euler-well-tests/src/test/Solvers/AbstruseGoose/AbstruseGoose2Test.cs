using System;
using System.Linq;
using DistilledB.EulerWell.Solvers.AbstruseGoose;
using NUnit.Framework;
using DistilledB.EulerWell.Extensions;

namespace DistilledB.EulerWell.Solvers.AbstruseGoose {
  public class AbstruseGoose2Test : ProblemTestHarness<AbstruseGoose2Solver, string> {
    [Test]
    public override void TestExpectedEulerWellSolution() {
      foreach (var s in ProblemSolver.Strategies) {
        Assert.AreEqual("5926535897", s());
      }
    }

    [Test]
    public void Foo() {
      var a = new AbstruseGoose3Solver();
      Assert.AreEqual("73939133", a.DepthFirstSearch());
    }
  }
}