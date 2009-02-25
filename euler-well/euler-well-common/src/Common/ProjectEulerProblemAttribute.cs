using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistilledB.EulerWell.Common
{
  [AttributeUsage(AttributeTargets.Class)]
  public class ProjectEulerProblemAttribute : System.Attribute
  {
    private int id;

    public ProjectEulerProblemAttribute(int id) {
      this.id = id;
    }

    public string Name { get; set; }
    public int Id { get { return id; } }
    public string Description { get; set; }
  }
}