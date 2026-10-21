using Libri.Kap07;

Llogari l = new Llogari();
l.Depozito(100);
l.Terhiq(30);
l.Terhiq(1000);              // refuzohet
Console.WriteLine(l.Gjendja); // 70
