class Program
{
    static void Main()
    {
        double[] grupi = { 8, 9.5, 7, 10 };

        Console.WriteLine(LlogaritMesataren(8, 9.5));
        Console.WriteLine(LlogaritMesataren(8, 9.5, 7));
        Console.WriteLine(LlogaritMesataren(grupi));
    }

    static double LlogaritMesataren(double a, double b)
    {
        return (a + b) / 2;
    }

    static double LlogaritMesataren(double a, double b, double c)
    {
        return (a + b + c) / 3;
    }

    static double LlogaritMesataren(double[] notat)
    {
        double shuma = 0;
        foreach (double nota in notat)
        {
            shuma += nota;
        }
        return shuma / notat.Length;
    }
}
