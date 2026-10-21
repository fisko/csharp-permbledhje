namespace Libri.Kap07;

public class Student
{
    private int mosha;

    public int Mosha
    {
        get { return mosha; }
        set
        {
            if (value >= 0 && value <= 130)
                mosha = value;
            else
                Console.WriteLine($"Moshë e pavlefshme: {value}");
        }
    }
}
