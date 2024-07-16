int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result);

Console.WriteLine("Data Loss = Decimal to Int");
decimal myDecimala = 3.14m;
Console.WriteLine($"decimal: {myDecimala}");

int myInta = (int)myDecimala;
Console.WriteLine($"int: {myInta}");

Console.WriteLine("Narrowing Conversion");
decimal smyDecimal = 1.23456789m;
float smyFloat = (float)smyDecimal;

Console.WriteLine($"Decimal: {smyDecimal}");
Console.WriteLine($"Float  : {smyFloat}");


Console.WriteLine("Performing Data Conversion\n");
int ifirst = 5;
int isecond = 7;
string message = ifirst.ToString() + isecond.ToString();
Console.WriteLine(message);

string afirst = "5";
string asecond = "7";
int sum = int.Parse(afirst) + int.Parse(asecond);
Console.WriteLine(sum);

