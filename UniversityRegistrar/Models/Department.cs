using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Department
  {
    public Department()
    {
      this.Courses = new HashSet<CourseDepartmentStudent>();
    }

    public int DepartmentId { get; set; }
    public string DepartmentName { get; set; }
    public virtual ICollection<CourseDepartmentStudent> Courses { get; set; }
  }
}