using System.Globalization;

const string Skedari = "regjistri.csv";

// Në skedar përdorim gjithmonë pikën dhjetore (8.5), pavarësisht nga gjuha e Windows-it.
CultureInfo kultura = CultureInfo.InvariantCulture;

List<Student> studentet = LexoSkedarin();
Console.WriteLine($"U lexuan {studentet.Count} studentë nga {Skedari}.");

while (true)
{
    Console.WriteLine("\n1.Shto  2.Shfaq  3.Kërko sipas indeksit  0.Dil");
    Console.Write("Zgjedhja: ");
    string zgjedhja = Console.ReadLine() ?? "0";

    if (zgjedhja == "0") break;
    else if (zgjedhja == "1") Shto();
    else if (zgjedhja == "2") Shfaq();
    else if (zgjedhja == "3") Kerko();
    else Console.WriteLine("Zgjedhje e panjohur.");
}

RuajSkedarin();
Console.WriteLine("Ndryshimet u ruajtën. Mirupafshim!");

List<Student> LexoSkedarin()
{
    List<Student> lista = new();
    if (!File.Exists(Skedari)) return lista;

    try
    {
        foreach (string rreshti in File.ReadAllLines(Skedari))
        {
            string[] pjeset = rreshti.Split(';');
            if (pjeset.Length != 3 ||
                !double.TryParse(pjeset[2], NumberStyles.Float,
                                 kultura, out double mesatarja))
            {
                Console.WriteLine($"Rresht i dëmtuar, u kapërcye: {rreshti}");
                continue;
            }
            lista.Add(new Student(pjeset[0], pjeset[1], mesatarja));
        }
    }
    catch (IOException ex)
    {
        Console.WriteLine("Gabim gjatë leximit: " + ex.Message);
    }
    return lista;
}

void Shto()
{
    Console.Write("Indeksi: ");
    string indeksi = Console.ReadLine() ?? "";
    if (studentet.Any(s => s.Indeksi == indeksi))
    {
        Console.WriteLine("Ky indeks ekziston tashmë.");
        return;
    }

    Console.Write("Emri: ");
    string emri = Console.ReadLine() ?? "";
    Console.Write("Mesatarja: ");
    string tekst = (Console.ReadLine() ?? "").Replace(',', '.');

    if (!double.TryParse(tekst, NumberStyles.Float, kultura, out double mesatarja)
        || mesatarja < 0 || mesatarja > 10)
    {
        Console.WriteLine("Mesatarja duhet të jetë numër nga 0 deri në 10.");
        return;
    }

    studentet.Add(new Student(indeksi, emri, mesatarja));
    Console.WriteLine("U shtua.");
}

void Shfaq()
{
    if (studentet.Count == 0) Console.WriteLine("Regjistri është bosh.");
    foreach (Student s in studentet) Console.WriteLine(s);
}

void Kerko()
{
    Console.Write("Indeksi: ");
    string indeksi = Console.ReadLine() ?? "";
    Student? s = studentet.Find(x => x.Indeksi == indeksi);
    Console.WriteLine(s is null ? "Nuk u gjet." : s.ToString());
}

void RuajSkedarin()
{
    IEnumerable<string> rreshtat = studentet.Select(s =>
        $"{s.Indeksi};{s.Emri};{s.Mesatarja.ToString(kultura)}");
    File.WriteAllLines(Skedari, rreshtat);
}

class Student
{
    public string Indeksi { get; }
    public string Emri { get; }
    public double Mesatarja { get; }

    public Student(string indeksi, string emri, double mesatarja)
    {
        Indeksi = indeksi;
        Emri = emri;
        Mesatarja = mesatarja;
    }

    public override string ToString() =>
        $"{Indeksi} | {Emri} | {Mesatarja.ToString("F2", CultureInfo.InvariantCulture)}";
}
