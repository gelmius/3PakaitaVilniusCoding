//5 Uzduotis

Console.WriteLine("Iveskite skaiciu");

double skaicius = double.Parse(Console.ReadLine());

if (skaicius > 0)
{


    Console.WriteLine("kvadratine saknis: "+ Math.Sqrt(skaicius));
}
else
{
    Console.WriteLine("Kvadratinės šaknies apskaičiuoti negalima");
}