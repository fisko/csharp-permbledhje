using Libri.Kap07;

Student s = new Student();
s.Mosha = 20;
Console.WriteLine(s.Mosha);

s.Mosha = 200;              // refuzohet
Console.WriteLine(s.Mosha); // mbetet 20
