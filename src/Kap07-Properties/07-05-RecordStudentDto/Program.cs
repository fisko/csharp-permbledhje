StudentDto s1 = new("Arben", "Krasniqi", 8.7);
StudentDto s2 = new("Arben", "Krasniqi", 8.7);
Console.WriteLine(s1 == s2); // True

public record StudentDto(string Emri, string Mbiemri, double Mesatarja);
