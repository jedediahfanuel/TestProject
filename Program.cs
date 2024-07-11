Console.Clear();

Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Console.WriteLine(dice.Next(1,20));


// Overloaded Methods
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

// Overloaded Random
Random diced = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50,101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"First roll: {roll2}");
Console.WriteLine($"First roll: {roll3}");


int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);
