// See https://aka.ms/new-console-template for more information
Console.WriteLine("1. Kijavo kotletas 5.5e");
Console.WriteLine("2. Saltibarsiai 3.2e");
Console.WriteLine("3. Pica 7e");
Console.WriteLine("4. Kebabas 4.5e");
Console.WriteLine("5. Plovas 3.3e");

int meniu = int.Parse(Console.ReadLine());

Console.WriteLine("Ar norite pridėti sūrį (+1€)? (y/n)");

char papildomai = char.Parse(Console.ReadLine());



switch (meniu)
{
    case 1:
        if (papildomai == 'y')
        {
            Console.WriteLine("Kijavo kotletas 6.5e");
        }
        else
        {
            Console.WriteLine("Kijavo kotletas 5.5e");
        }

        break;
    case 2:
        if (papildomai == 'y')
        {
            Console.WriteLine("Saltibarsiai 4.2e");
        }
        else
        {
            Console.WriteLine("Saltibarsiai 3.2e");
        }

        break;
    case 3:
        if (papildomai == 'y')
        {
            Console.WriteLine("Pica 8e");
        }
        else
        {
            Console.WriteLine("Pica 7e");
        }

        break;
    case 4:
        if (papildomai == 'y')
        {
            Console.WriteLine("Kebabas 5.5e");
        }
        else
        {
            Console.WriteLine("Kebabas 4.5e");
        }

        break;
    case 5:
        if (papildomai == 'y')
        {
            Console.WriteLine("Plovas 4.3e");
        }
        else
        {
            Console.WriteLine("Plovas 3.3e");
        }

        break;
    default:
        break;
}
