// ArrayTypeMismatchException
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = (Object[])names;

Object obj = (Object)13;
objs[2] = obj; // ArrayTypeMismatchException occurs



// DivideByZeroException
int number1 = 3000;
int number2 = 0;
Console.WriteLine(number1 / number2); // DivideByZeroException occurs



// FormatException
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs



// IndexOutOfRangeException
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs



// InvalidCastException
object obj = "This is a string";
int num = (int)obj;



// NullReferenceException
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;

string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());


// OverflowException
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);