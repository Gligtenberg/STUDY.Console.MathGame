var date = DateTime.Now;

string name = GetName();

Menu(name);

string GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}

void Menu(string name)
{
    Console.WriteLine("--------------------------");
    Console.WriteLine($"Hello {name.ToUpper()}. It's {date.DayOfWeek}. This is your math's game. It is great that you are working on improving yourself\n");
    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
A - Addition
S - Substraction
M - Multiplication
D - Division
Q - Quit the program");
    Console.WriteLine("--------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame("Addition Game Selected");
            break;
        case "s":
            SubstractionGame("Substraction game selected");
            break;
        case "m":
            MultiplecationGame("Multiplecation game selected");
            break;
        case "d":
            DivisionGame("Division game selected");
            break;
        case "q":
            Console.WriteLine("Goodbye");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            break;

    }
}

void AdditionGame(string message)
{
    Console.WriteLine(message);

    var random = new Random();
    int firstNumber = random.Next(1, 9);
    int secondNumber = random.Next(1, 9);

    Console.WriteLine($"{firstNumber} + {secondNumber}");
    var result = Console.ReadLine();

    if(int.Parse(result) == firstNumber + secondNumber)
    {
        Console.Write("Your answer was correct!");
    }
    else
    {
        Console.WriteLine("Your answer was incorrect.");
    }

}

void SubstractionGame(string message)
{
    Console.WriteLine(message);
}

void MultiplecationGame(string message)
{
    Console.WriteLine(message);
}

void DivisionGame(string message)
{
    Console.WriteLine(message);
}

