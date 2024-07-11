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
