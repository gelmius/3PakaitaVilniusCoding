// See https://aka.ms/new-console-template for more information
Console.WriteLine("iveskite valandini atlyginima ir dirbtu valandu skaiciu per savaite");

double valandinis = Double.Parse(Console.ReadLine());
double valandos = Double.Parse(Console.ReadLine());
double virsvalandziai = 0, atlyginimas = 0;
if (valandos > 40)
{
    virsvalandziai = valandos - 40;
    atlyginimas = (40 * valandinis) + (virsvalandziai * valandinis * 1.5);
    atlyginimas -= atlyginimas * 0.15;//isskaiciuojam 15% mokesciu
}
else
{
    atlyginimas = valandos * valandinis;
    atlyginimas -= atlyginimas * 0.15;//isskaiciuojam 15% mokesciu
}

Console.WriteLine("Atliginimas: " + atlyginimas);
