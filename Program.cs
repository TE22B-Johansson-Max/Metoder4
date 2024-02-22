using Microsoft.VisualBasic;

var condition1 = true;



while (condition1)
{
    condition1 = Meny(condition1);
}


static bool Meny(bool quit)
{
    Console.WriteLine("-Alternativ-");
    Console.WriteLine("1. Addera tre tal");
    Console.WriteLine("2. Största talet av två tal");
    Console.WriteLine("3. Avsluta Programmet");
    Console.Write("Välj alternativ baserat på siffra: ");
    string val = Console.ReadLine();
    switch (val)
    {
        case "1":
            Addition();
            break;

        case "2":
            StörstaTal();
            break;

        case "3":
         quit = false;
            break;

        default:
            Console.Write("Du måste svara med ett av alternativen: ");
            val = Console.ReadLine();
            break;
    }
    Console.WriteLine("-------------------------------");

    return quit;
}


static int Addition()
{
    Console.Write("Välj tal 1: ");
    string StringTal1 = Console.ReadLine();

    Console.Write("Välj tal 2: ");
    string StringTal2 = Console.ReadLine();

    Console.Write("Välj tal 3: ");
    string StringTal3 = Console.ReadLine();

    int IntTal1 = int.Parse(StringTal1);
    int IntTal2 = int.Parse(StringTal2);
    int IntTal3 = int.Parse(StringTal3);
    int summa = IntTal1 + IntTal2 + IntTal3;
    Console.WriteLine($"Summan av de tre talen är {summa}");
    return summa;
}

static void StörstaTal()
{
    Console.Write("Skriv in ett tal: ");
    string StringTal1 = Console.ReadLine();
    Console.Write("Skriv in ett annat tal: ");
    string StringTal2 = Console.ReadLine();

    int IntTal1 = int.Parse(StringTal1);
    int IntTal2 = int.Parse(StringTal2);

    if (IntTal1 > IntTal2)
    {
        Console.WriteLine($"{IntTal1} är det större talet bland de två");
    }
    else if (IntTal1 == IntTal2)
    {
        Console.WriteLine("Talen är lika stora (du klarade inte av att följae en enkel instruktion)");
    }
    else
    {
        Console.WriteLine($"{IntTal2} är större.");
    }
}