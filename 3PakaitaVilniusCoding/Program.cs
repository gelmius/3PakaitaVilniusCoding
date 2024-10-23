//1 Uzduotis

Console.WriteLine("Iveskite skaiciu");

double skaicius = double.Parse( Console.ReadLine());

if(skaicius > 0)
{
    Console.WriteLine("Skaičius yra teigiamas");
}
else
{
    Console.WriteLine("Skaičius nėra teigiamas");
}