// Z 7.4 — Fahrenheit si property vetëm-për-lexim, e llogaritur.
Temperatura t = new Temperatura { Celsius = 25 };
Console.WriteLine($"{t.Celsius}°C = {t.Fahrenheit}°F");

public class Temperatura
{
    public double Celsius { get; set; }

    public double Fahrenheit
    {
        get { return Celsius * 9.0 / 5 + 32; }
    }
}
