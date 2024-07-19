// String Format() Func
string first = "Hello";
string second = "World";
string result = string.Format("{0} {1}!", first, second);
Console.WriteLine(result);


// String Interpolation
string frst = "Hello";
string scnd = "World";
Console.WriteLine($"{frst} {scnd}!");
Console.WriteLine($"{scnd} {frst}!");
Console.WriteLine($"{frst} {frst} {frst}!");


// Formatting Currency
decimal price = 123.45m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");



// Formatting Numbers
decimal measurement = 123456.78912m;
Console.WriteLine($"Measurement: {measurement:N} units");



// Formatting Percentages
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P2}");
