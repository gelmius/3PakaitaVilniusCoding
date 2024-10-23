

Random r = new Random();

int randomSkaicius = r.Next(1, 11);

Console.WriteLine("Iveskite skaiciu");

int skaicius = int.Parse(Console.ReadLine());

if (skaicius == randomSkaicius)
{
    Console.WriteLine("Laimėjote prizą");
}
else
{
    Console.WriteLine("Deja, nesutapo");
}