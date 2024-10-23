Console.WriteLine("Iveskite 3 pazymiu vertes");

int pazymys1 = int.Parse(Console.ReadLine());
int pazymys2 = int.Parse(Console.ReadLine());
int pazymys3 = int.Parse(Console.ReadLine());

double vidurkis = (pazymys1+pazymys2+pazymys3);
vidurkis = vidurkis / 3;

if (vidurkis >= 5)
{
    Console.WriteLine("Patenkinamas " + vidurkis);
}
else
{
    Console.WriteLine("Nepatenkinamas " + vidurkis);
}