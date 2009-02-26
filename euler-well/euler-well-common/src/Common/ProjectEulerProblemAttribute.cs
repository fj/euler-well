using System;

namespace DistilledB.EulerWell.Common {
  [AttributeUsage(AttributeTargets.Class)]
  public class ProjectEulerProblemAttribute : Attribute {
    private readonly int id;

    public ProjectEulerProblemAttribute(int id) {
      this.id = id;
    }

    public string Name { get; set; }

    public int Id {
      get { return id; }
    }

    public string Description { get; set; }
  }
}