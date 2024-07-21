﻿Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetRandom();
        var roll = GetRandom();

        Console.WriteLine($"\nRoll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetRandom()
{
	return random.Next(0,11);
}

string WinOrLose(int target, int roll)
{
	return target < roll ? "You win!" : "You lose!";
}

bool ShouldPlay()
{
	string response = Console.ReadLine();
	return response.ToLower().Equals("y");
}
