public class Topi
{
    public string Lloji { get; set; } = "";
    public string Ngjyra { get; set; } = "";

    private double cmimi;
    public double Cmimi
    {
        get { return cmimi; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Çmimi s'mund të jetë negativ!");
                return;         // refuzon vlerën, mban të vjetrën
            }
            cmimi = value;
        }
    }

    public Topi(string lloji, string ngjyra, double cmimi)
    {
        Lloji = lloji;
        Ngjyra = ngjyra;
        Cmimi = cmimi;          // kalon nëpër set -> validohet
    }

    public Topi(string lloji, string ngjyra)
        : this(lloji, ngjyra, 0)
    {
    }

    public override string ToString()
        => $"Top {Lloji}, {Ngjyra}, {Cmimi} den.";
}
