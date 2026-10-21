using Libri.Kap09;

List<Njeri> njerezit = new List<Njeri>
{
    new Student("Arben"),
    new Profesor("Dr. Leka"),
    new Student("Besa"),
};

foreach (Njeri n in njerezit)
    n.Prezanto();
