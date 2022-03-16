namespace UniversityRegistrar.Models
{
  public class CourseDepartmentStudent
  {       
    public int CourseDepartmentStudentId { get; set; }
    public int StudentId { get; set; }
    public int DepartmentId { get; set; }
    public int CourseId { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
    public virtual Department Department { get; set; }
  }
}