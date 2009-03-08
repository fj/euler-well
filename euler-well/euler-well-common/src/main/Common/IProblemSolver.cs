using System.Collections.Generic;

namespace DistilledB.EulerWell.Common {
  public interface IProblemSolver<T> {
    IEnumerable<SolutionStrategy<T>> Strategies { get; }
  }
}