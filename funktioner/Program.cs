internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välj uppgift:");
        Console.WriteLine("1 - Uppgift 1");
        Console.WriteLine("2 - Uppgift 2");
        Console.WriteLine("3 - Uppgift 3");
        Console.WriteLine("4 - Uppgift 4");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Uppgift1();
                break;
            case "2":
                Uppgift2();
                break;
            case "3":
                Uppgift3();
                break;
            case "4":
                Uppgift4();
                break;
            default:
                Console.WriteLine("Ogiltigt val.");
                break;
        }
    }

    private static void Uppgift1()
    {
        Console.WriteLine("Ange belopp i SEK: ");
        double sek = double.Parse(Console.ReadLine());
        double yen = ConvertToYen(sek);
        Console.WriteLine($"{sek} SEK är {yen} Yen.");
    }

    private static double ConvertToYen(double sek)
    {
        double exchangeRate = 14.50; 
        return sek * exchangeRate;
    }

    private static void Uppgift2()
    {
        Console.WriteLine("Ange basen på rektangeln: ");
        double baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine("Ange höjden på rektangeln: ");
        double height = double.Parse(Console.ReadLine());

        double area = CalculateArea(baseLength, height);
        double perimeter = CalculatePerimeter(baseLength, height);

        Console.WriteLine($"Arean är: {area}");
        Console.WriteLine($"Omkretsen är: {perimeter}");
    }

    private static double CalculateArea(double baseLength, double height)
    {
        return baseLength * height;
    }

    private static double CalculatePerimeter(double baseLength, double height)
    {
        return 2 * (baseLength + height);
    }

    private static void Uppgift3()
    {
        Console.WriteLine("Ange vilket Lucas-nummer du vill beräkna: ");
        int n = int.Parse(Console.ReadLine());
        int result = LucasNumber(n);
        Console.WriteLine($"Lucas nummer för {n} är {result}");
    }

    private static int LucasNumber(int n)
    {
        if (n == 0) return 2;
        if (n == 1) return 1;
        return LucasNumber(n - 1) + LucasNumber(n - 2);
    }

    private static void Uppgift4()
    {
        Console.WriteLine("Ange basen: ");
        double baseNum = double.Parse(Console.ReadLine());
        Console.WriteLine("Ange exponenten: ");
        int exponent = int.Parse(Console.ReadLine());

        double result = Power(baseNum, exponent);
        Console.WriteLine($"{baseNum} upphöjt till {exponent} är {result}");
    }

    private static double Power(double baseNum, int exponent)
    {
        if (exponent == 0) return 1;
        if (exponent > 0) return baseNum * Power(baseNum, exponent - 1);
        return 1 / Power(baseNum, -exponent);
    }
}
