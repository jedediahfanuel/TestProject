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

string value1 = "5";
string value2 = "7";
int hresult = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(hresult);

int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

 // TRY PARSE TO AVOID RUNTIME ERROR WHILE CASTING
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");


// CHALLANGE COMBINE STRING & NUMERIC VALUES
string[] valuelcs = { "12.3", "45", "ABC", "11", "DEF" };

decimal ttl = 0m;
string msg = "";

foreach (var valuelc in valuelcs)
{
    decimal nbr; // stores the TryParse "out" valuelc
    if (decimal.TryParse(valuelc, out nbr))
    {
        ttl += nbr;
    } else
    {
        msg += valuelc;
    }
}

Console.WriteLine($"msg: {msg}");
Console.WriteLine($"ttl: {ttl}");
