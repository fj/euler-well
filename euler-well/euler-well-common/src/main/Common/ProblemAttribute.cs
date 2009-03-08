using System;

namespace DistilledB.EulerWell.Common {
  [AttributeUsage(AttributeTargets.Class)]
  public class ProblemAttribute : Attribute {
    public string Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
  }
}