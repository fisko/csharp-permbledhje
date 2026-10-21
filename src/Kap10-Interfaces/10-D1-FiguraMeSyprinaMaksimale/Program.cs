using Libri.Kap10;

List<Figura> figurat = new List<Figura>
{
    new Rrethi(2), new Katrori(3), new Rrethi(1),
};

Figura meEMadhja = figurat[0];
foreach (Figura f in figurat)
    if (f.Syprina() > meEMadhja.Syprina())
        meEMadhja = f;

Console.WriteLine($"Syprina më e madhe: {meEMadhja.Syprina():F2}");
