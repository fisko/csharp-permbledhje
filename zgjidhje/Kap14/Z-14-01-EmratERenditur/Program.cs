// Z 14.1 — Ruaj emrat në skedar, lexoji dhe shfaqi të renditur.
string[] emrat = { "Drin", "Arben", "Besa" };
File.WriteAllLines("emrat.txt", emrat);

string[] teLexuar = File.ReadAllLines("emrat.txt");
Array.Sort(teLexuar);

foreach (string emri in teLexuar)
    Console.WriteLine(emri);
