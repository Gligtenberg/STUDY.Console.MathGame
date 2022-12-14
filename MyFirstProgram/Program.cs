using static System.Formats.Asn1.AsnWriter;

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
            AdditionGame("Addition Game");
            break;
        case "s":
            SubstractionGame("Substraction Game");
            break;
        case "m":
            MultiplecationGame("Multiplecation Game");
            break;
        case "d":
            DivisionGame("Division Game");
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
    Console.Clear();
    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for(int i=0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.Clear();
        Console.WriteLine($"{firstNumber} + {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber + secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}");
    }

}

void SubstractionGame(string message)
{
    Console.WriteLine(message);
    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.Clear();
        Console.WriteLine($"{firstNumber} - {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}");
    }
}

void MultiplecationGame(string message)
{

    Console.WriteLine(message);

    var random = new Random();
    var score = 0;

    int firstNumber;
    int secondNumber;

    for (int i = 0; i < 5; i++)
    {
        firstNumber = random.Next(1, 9);
        secondNumber = random.Next(1, 9);

        Console.Clear();
        Console.WriteLine($"{firstNumber} * {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}");
    }
}

void DivisionGame(string message)
{

    var score = 0;

    for (int i=0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine(message);
        var divisionNumbers = GetDivisionNumbers();
        var firstNumber = divisionNumbers[0];
        var secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");
        var result = Console.ReadLine();

        if (int.Parse(result) == firstNumber / secondNumber)
        {
            Console.WriteLine("Your answer was correct! Press any key for the next question");
            score++;
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Your answer was incorrect. Press any key for the next question");
            Console.ReadLine();
        }

        if (i == 4) Console.WriteLine($"Game Over. Your final score is {score}");

}

    
}


int[] GetDivisionNumbers()
{
    var random = new Random();

    var firstNumber = random.Next(0, 99);
    var secondNumber = random.Next(0, 99);

    var result = new int[2];

    while (firstNumber % secondNumber != 0)
    {
        firstNumber = random.Next(1, 99);
        secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;

    return result;
} 

