class Lenda
{
    public string Emri { get; set; }
    public int Ects { get; set; }

    public Lenda(string emri, int ects)
    {
        Emri = emri;
        Ects = ects;
    }
}

class Profesor
{
    public string Emri { get; set; }
    public List<Lenda> Lendet { get; set; } = new();

    public Profesor(string emri)
    {
        Emri = emri;
    }

    public void ShtoLende(Lenda lenda)
    {
        Lendet.Add(lenda);
    }
}
