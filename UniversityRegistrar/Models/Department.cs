using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.JoinEntities = new HashSet<CourseDepartmentStudent>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public virtual ICollection<CourseDepartmentStudent> JoinEntities { get; set; }
  }
}