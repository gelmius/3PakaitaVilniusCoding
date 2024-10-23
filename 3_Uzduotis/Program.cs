Console.WriteLine("Iveskite 2 skaicius ir veiksma (+, -, *, /) ");

double skaicius = double.Parse(Console.ReadLine());
double skaicius2 = double.Parse(Console.ReadLine());

char veiksmas = char.Parse(Console.ReadLine());

switch (veiksmas)
{	case '+':
		Console.WriteLine("Suma: " + (skaicius + skaicius2));
break;
    case '-':
        Console.WriteLine("Skirtumas: " + (skaicius - skaicius2));
        break;
    case '*':
        Console.WriteLine("Sandauga: " + (skaicius * skaicius2));
        break;
    case '/':
        Console.WriteLine("Dalyba: " + (skaicius / skaicius2));
        break;
    default:
		break;
}