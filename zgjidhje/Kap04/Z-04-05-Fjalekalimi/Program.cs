// Z 4.5 — do-while: kërko fjalëkalimin derisa të jetë "1234".
string fjalekalimi;
do
{
    Console.Write("Shkruaj fjalëkalimin: ");
    fjalekalimi = Console.ReadLine() ?? "";
} while (fjalekalimi != "1234");

Console.WriteLine("Hyrja u pranua!");
