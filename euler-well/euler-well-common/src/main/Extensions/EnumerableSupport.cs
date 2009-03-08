using System;
using System.Collections.Generic;
using System.Linq;

namespace DistilledB.EulerWell.Extensions {
  public static class EnumerableSupport {
    /// <summary>
    /// Takes all contiguous subsequences of the specified size from the sequence.
    /// </summary>
    /// <returns></returns>
    public static IEnumerable<IEnumerable<T>> ContiguousSubsequences<T>(this IEnumerable<T> input, int windowSize) {
      if (windowSize < 1)
        yield break;

      int index = 0;
      var window = new List<T>(windowSize);
      window.AddRange(new T[windowSize]);
      foreach (var item in input)
      {
        bool initializing = index < windowSize;

        if (!initializing) {
          window = window.Skip(1).ToList();
          window.Add(default(T));
        }

        int itemIndex = initializing ? index : windowSize - 1;
        window[itemIndex] = item;

        index++;
        bool initialized = index >= windowSize;
        if (initialized)
          yield return new List<T>(window);
      }
    }
  }
}