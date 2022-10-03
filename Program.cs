// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.WriteLine("What is your Name?");
    string playerName = Console.ReadLine();
    Console.WriteLine($" {playerName} Give me a number between 1 and 100");
    int answer = Convert.ToInt32(Console.ReadLine());
    int remander = answer % 2;
    if (answer < 1 || answer >= 100)
    {
        Console.WriteLine("I said between 1-100! You lose my game.");
    }

    else if (answer < 60 && remander != 0)
    {
        Console.WriteLine($"{answer} Odd and less than 60");
    }

    else if (answer >= 2 && answer < 24 && remander == 0)
    {
        Console.WriteLine("Even and less than 25");
    }

    else if (answer > 26 && answer < 60 && remander == 0)
    {
        Console.WriteLine("Even and between 26 and 60");
    }

    else if (answer > 60 && remander == 0)
    {
        Console.WriteLine($"{answer} Even and greater than 60");
    }

    else if (answer > 60 && remander != 0)
    {
        Console.WriteLine($"Odd and greater than 60");

    }
    
    Console.WriteLine("Would you Like to coninue? Select Y or N");
    string endgame = Console.ReadLine();

    if (endgame == "Y")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Good Bye, Hope you had fun!");
        break;
    }
}