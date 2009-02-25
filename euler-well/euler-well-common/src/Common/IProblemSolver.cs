using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistilledB.EulerWell.Common {
  public delegate T SolutionStrategy<T>();

  public interface IProblemSolver<T> {
    IEnumerable<SolutionStrategy<T>> Strategies { get; }
  }
}