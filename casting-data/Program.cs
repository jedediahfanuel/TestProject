int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine("Data Loss = Decimal to Int");
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
