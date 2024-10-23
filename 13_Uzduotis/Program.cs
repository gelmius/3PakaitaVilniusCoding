// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Sedanas 100€");
Console.WriteLine("2. SUV 150€");
Console.WriteLine("3. Mikroautobusas 120€");
int meniu = int.Parse(Console.ReadLine());

Console.WriteLine("Ar norite apsaugos nuo vagystės? (+50€) (y/n)");

char apsaugoVagyste = char.Parse(Console.ReadLine());

Console.WriteLine("Ar norite apsaugos nuo stichijų? (+30€) (y/n)");

char apsaugoStichijos = char.Parse(Console.ReadLine());
int suma = 0;
switch (meniu)
{
	case 1:
        suma = 100;
        if (apsaugoVagyste == 'y')
        {
            suma += 50;
        }
        if (apsaugoStichijos == 'y')
        {
            suma += 30;
        }
        Console.WriteLine("Sedanas " + suma);

        break;
    case 2:
        suma = 150;
        if (apsaugoVagyste == 'y')
        {
            suma += 50;
        }
        if (apsaugoStichijos == 'y')
        {
            suma += 30;
        }
        Console.WriteLine("SUV " + suma);

        break;
    case 3:
        suma = 120;
        if (apsaugoVagyste == 'y')
        {
            suma += 50;
        }
        if (apsaugoStichijos == 'y')
        {
            suma += 30;
        }
        Console.WriteLine("Mikroautobusas " + suma);

        break;
    default:
		break;
}