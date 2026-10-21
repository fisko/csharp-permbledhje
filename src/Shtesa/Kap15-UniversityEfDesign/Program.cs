// Ky projekt përmban vetëm modelin e entiteteve. Për EF Core të plotë,
// shto paketat Microsoft.EntityFrameworkCore dhe provider-in që përdor.
Console.WriteLine("Modeli konceptual për University Management System.");

public class Student
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public List<Enrollment> Enrollments { get; set; } = new();
}

public class Course
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public int Credits { get; set; }
    public List<Enrollment> Enrollments { get; set; } = new();
}

public class Enrollment
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public Student Student { get; set; } = null!;
    public int CourseId { get; set; }
    public Course Course { get; set; } = null!;
    public int? Grade { get; set; }
    public DateTime EnrolledAt { get; set; } = DateTime.Now;
}
