Console.WriteLine("Iveskite du skaicius");

double skaicius = double.Parse(Console.ReadLine());
double skaicius2 = double.Parse(Console.ReadLine());

if (skaicius > skaicius2)
{
    Console.WriteLine("Pirmas skaicius didesnis");
}
else if (skaicius < skaicius2)
{
    Console.WriteLine("Antras skaicius didesnis");
}