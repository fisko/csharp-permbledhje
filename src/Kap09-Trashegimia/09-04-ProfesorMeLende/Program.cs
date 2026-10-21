Profesor p = new Profesor("Dr. Berisha");
p.ShtoLende(new Lenda("Programim", 6));
p.ShtoLende(new Lenda("Bazat e të dhënave", 5));

Console.WriteLine(p.Emri);
foreach (Lenda l in p.Lendet)
    Console.WriteLine($"- {l.Emri} ({l.Ects} ECTS)");
