namespace Libri.Kap15;

public class Profesor
{
    public int Id { get; set; }
    public string Emri { get; set; }
    public List<Student> Studentet { get; set; } = new();
}

public class Student
{
    public int Id { get; set; }
    public string Emri { get; set; }
    public int ProfesorId { get; set; }   // çelës i huaj
}
