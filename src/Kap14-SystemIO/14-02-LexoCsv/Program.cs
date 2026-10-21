List<Student> studentet = new();
string[] rreshtat = File.ReadAllLines("studentet.csv");

for (int i = 1; i < rreshtat.Length; i++)
{
    string[] pjeset = rreshtat[i].Split(';');
    studentet.Add(new Student(
        pjeset[0],
        pjeset[1],
        double.Parse(pjeset[2])));
}

class Student
{
    public string Indeksi { get; set; }
    public string Emri { get; set; }
    public double Mesatarja { get; set; }

    public Student(string indeksi, string emri, double mesatarja)
    {
        Indeksi = indeksi;
        Emri = emri;
        Mesatarja = mesatarja;
    }
}
