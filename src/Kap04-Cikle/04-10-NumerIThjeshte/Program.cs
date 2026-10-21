int n = 29;
bool eshteIThjeshte = true;

if (n < 2)
{
    eshteIThjeshte = false;
}
else
{
    for (int i = 2; i <= Math.Sqrt(n); i++)
    {
        if (n % i == 0)
        {
            eshteIThjeshte = false;
            break;
        }
    }
}

Console.WriteLine(eshteIThjeshte ? "I thjeshtë" : "Jo i thjeshtë");
