using Libri.Kap06;

Student s = new Student("Arben",
    new double[] { 8, 9, 7, 10 });

Console.WriteLine($"{s.Emri}: {s.Mesatarja():F2}");
