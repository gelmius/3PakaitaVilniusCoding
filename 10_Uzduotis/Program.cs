Console.WriteLine("Iveskite skaiciu");

int skaicius = int.Parse(Console.ReadLine());

if (skaicius > 0)
{
    Console.WriteLine("Teigiamas");
}
else
{
    Console.WriteLine("Neigiamas");
}

if (skaicius %2 == 0)
{
    Console.WriteLine("Lyginis");
}
else
{
    Console.WriteLine("Nelyginis");
}