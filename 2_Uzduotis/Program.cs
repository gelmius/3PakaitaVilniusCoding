//2 Uzduotis

Console.WriteLine("Iveskite skaiciu");

double skaicius = double.Parse(Console.ReadLine());

if (skaicius % 2 == 0)
{
    Console.WriteLine("Skaičius yra lyginis");
}
else
{
    Console.WriteLine("Skaičius yra nelyginis");
}