using DistilledB.EulerWell.Common;
using NUnit.Framework;

namespace DistilledB.EulerWell.Solvers {
  [TestFixture]
  public abstract class ProblemTestHarness<T, U> where T : IProblemSolver<U>, new() {
    #region Setup/Teardown
    [SetUp]
    public void Begin() {
      ProblemSolver = new T();
    }
    #endregion

    protected T ProblemSolver { get; set; }

    public abstract void TestExpectedEulerWellSolution();
  }
}