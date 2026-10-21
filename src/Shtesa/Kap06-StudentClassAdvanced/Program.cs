var s = new Student("Ana Berisha", "INF-2026-01");
s.ShtoNote(10);
s.ShtoNote(9);
s.ShtoNote(8);
Console.WriteLine(s);

class Student
{
    public string Emri { get; }
    public string Indeksi { get; }
    private readonly List<int> _notat = new();

    public Student(string emri, string indeksi)
    {
        Emri = emri;
        Indeksi = indeksi;
    }

    public void ShtoNote(int nota)
    {
        _notat.Add(nota);
    }

    public double Mesatarja()
    {
        if (_notat.Count == 0) return 0;
        return _notat.Average();
    }

    public override string ToString()
    {
        return $"{Emri} ({Indeksi}) - mesatarja {Mesatarja():F2}";
    }
}
