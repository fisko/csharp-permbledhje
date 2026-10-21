using Libri.Kap09;

Student s = new Student();
s.Emri = "Arben";
s.Fakulteti = "Informatikë";

Profesor p = new Profesor();
p.Emri = "Dr. Leka";
p.Eksperienca = 12;

Console.WriteLine($"{s.Emri}, {s.Fakulteti}");
Console.WriteLine($"{p.Emri}, {p.Eksperienca} vjet përvojë");
