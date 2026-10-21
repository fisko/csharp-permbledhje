using Libri.Kap13;

List<Student> studentet = new List<Student>
{
    new Student { Emri = "Arben", Nota = 8.5 },
    new Student { Emri = "Besa",  Nota = 4.0 },
    new Student { Emri = "Drin",  Nota = 6.8 },
};

double mesatarja = studentet.Average(s => s.Nota);
double meLarta   = studentet.Max(s => s.Nota);
int kaluesit     = studentet.Count(s => s.Nota > 5);

Console.WriteLine($"Mesatarja: {mesatarja:F2}");
Console.WriteLine($"Nota më e lartë: {meLarta}");
Console.WriteLine($"Kanë kaluar: {kaluesit}");
