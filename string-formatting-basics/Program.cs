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
