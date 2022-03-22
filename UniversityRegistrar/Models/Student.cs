using System.Collections.Generic;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public Student()
    {
      this.Courses = new HashSet<CourseDepartmentStudent>();
    }

    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Enrolled { get; set; }

    public virtual ICollection<CourseDepartmentStudent> Courses { get;}
  }
}