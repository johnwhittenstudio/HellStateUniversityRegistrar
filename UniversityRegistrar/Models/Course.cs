using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Course
  {
    public Course()
    {
      this.JoinEntries = new HashSet<CourseDepartmentStudent>();
    }

    public int CourseId { get; set; }
    public string Name { get; set; }
    public string CourseNumber { get; set; }
    public virtual ICollection<CourseDepartmentStudent> JoinEntries { get; set; }
  }
}