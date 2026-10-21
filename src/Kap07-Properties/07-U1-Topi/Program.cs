Topi[] topat =
{
    new Topi("futbolli", "i bardhë", 900),
    new Topi("basketbolli", "portokalli", 1200),
    new Topi("volejbolli", "i verdhë"),
};

topat[2].Cmimi = -50;    // provokon validimin
topat[2].Cmimi = 750;    // vlerë e rregullt

foreach (Topi t in topat)
    Console.WriteLine(t);
