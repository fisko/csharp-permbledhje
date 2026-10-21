int n = 30;

for (int numri = 2; numri <= n; numri++)
{
    bool iThjeshte = true;
    for (int d = 2; d < numri; d++)
    {
        if (numri % d == 0)   // gjeti pjesëtues -> jo i thjeshtë
        {
            iThjeshte = false;
            break;            // s'ka nevojë të vazhdojmë
        }
    }
    if (iThjeshte)
        Console.Write(numri + " ");
}
Console.WriteLine();
