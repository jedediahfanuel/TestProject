// Equity
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);
Console.WriteLine("a" == "a ");

Console.WriteLine("\n");

string myValue = "a";
Console.WriteLine(myValue == "a");

Console.WriteLine("\n");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("\n\n");

// Inquity
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

Console.WriteLine("\n");

string myV= "a";
Console.WriteLine(myV != "a");

Console.WriteLine("\n\n");

// Comparison Operator
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

Console.WriteLine("\n\n");

// Methods that return a Boolean Value
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

Console.WriteLine("\n\n");

// Logical Negation
// These two lines of code will create the same output
Console.WriteLine(pangram.Contains("fox") == false);
Console.WriteLine(!pangram.Contains("fox"));

Console.WriteLine("\n\n");

// Inequity vs logical negation
int a = 7;
int b = 6;
Console.WriteLine(a != b); // output: True
string s1 = "Hello";
string s2 = "Hello";
Console.WriteLine(s1 != s2); // output: False

Console.WriteLine("\n\n");

// ------------------------------------------------------------------ Ternary

Console.WriteLine("Ternary Operation");

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");
