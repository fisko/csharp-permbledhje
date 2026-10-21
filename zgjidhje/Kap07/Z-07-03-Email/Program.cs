// Z 7.3 — Email pranohet vetëm me shenjën @.
Student s = new Student();
s.Email = "arben.krasniqi";          // refuzohet
s.Email = "arben@studenti.mk";       // pranohet
Console.WriteLine($"Email: {s.Email}");

public class Student
{
    private string email = "";
    public string Email
    {
        get { return email; }
        set
        {
            if (!value.Contains('@'))
            {
                Console.WriteLine("Email i pavlefshëm (mungon @).");
                return;
            }
            email = value;
        }
    }
}
