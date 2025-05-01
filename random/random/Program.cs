internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Välj uppgift:");
        Console.WriteLine("1 - Uppgift 1");
        Console.WriteLine("2 - Uppgift 2");
        Console.WriteLine("3 - Uppgift 3");

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
            default:
                Console.WriteLine("Ogiltigt val.");
                break;
        }
    }

    private static void Uppgift1()
    {
        Random random = new Random();
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine(random.Next(1, 101));
        }
    }

    private static void Uppgift2()
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Gissa ett tal mellan 1 och 100!");

        while (guess != numberToGuess)
        {
            guess = int.Parse(Console.ReadLine());
            attempts++;

            if (guess < numberToGuess)
                Console.WriteLine("För lågt!");
            else if (guess > numberToGuess)
                Console.WriteLine("För högt!");
        }

        Console.WriteLine($"Rätt! Du gissade på {attempts} försök.");
    }

    private static void Uppgift3()
    {
        Random random = new Random();
        Console.WriteLine("Ange antal tärningar: ");
        int diceCount = int.Parse(Console.ReadLine());
        Console.WriteLine("Ange antal sidor på varje tärning: ");
        int sides = int.Parse(Console.ReadLine());

        for (int i = 0; i < diceCount; i++)
        {
            int result = random.Next(1, sides + 1);
            Console.WriteLine($"Tärning {i + 1}: {result}");
        }
    }
}
