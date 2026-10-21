Ligjerata l = new Ligjerata(2, "Trashëgimia në C#",
                            "doc. dr. Vlora");
Ushtrime u = new Ushtrime(3, "Detyra me klasa");

Console.WriteLine(l);    // ToString() i trashëguar nga Ora
Console.WriteLine(u);
l.Fol();
u.Fol();

// Bonusi: interface-i bashkon tipe të palidhura nga trashëgimia
INotueshme[] perVleresim = { l, new Provimi() };
foreach (INotueshme n in perVleresim)
    n.Vlereso(10);
