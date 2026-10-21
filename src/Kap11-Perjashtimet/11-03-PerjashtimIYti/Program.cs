using Libri.Kap11;

try
{
    VendosMoshen(-3);
}
catch (MoshePavlefshmeException ex)
{
    Console.WriteLine("U kap: " + ex.Message);
}

static void VendosMoshen(int mosha)
{
    if (mosha < 0)
        throw new MoshePavlefshmeException(
            "Mosha s'mund të jetë negative.");
    Console.WriteLine($"Mosha u vendos: {mosha}");
}
