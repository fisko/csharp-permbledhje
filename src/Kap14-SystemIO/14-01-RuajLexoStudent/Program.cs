string studenti = "Arben;Krasniqi;12345";
File.WriteAllText("student.txt", studenti);

string lexuar = File.ReadAllText("student.txt");
Console.WriteLine(lexuar);
