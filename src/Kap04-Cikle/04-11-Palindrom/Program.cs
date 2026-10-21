string tekst = "radar";
bool palindrom = true;

for (int i = 0; i < tekst.Length / 2; i++)
{
    if (tekst[i] != tekst[tekst.Length - 1 - i])
    {
        palindrom = false;
        break;
    }
}

Console.WriteLine(palindrom ? "Palindrom" : "Nuk është palindrom");
