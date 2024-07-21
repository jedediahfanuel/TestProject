// Example 1
CountTo(5);

void CountTo(int max) 
{
	for (int i = 0; i < max; i++)
	{
		Console.Write($"{i}, ");
	}
}


// Example 2
int[] schedule = {800, 1200, 1600, 2000};
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) 
{
	int diff = 0;
	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
	{
	    Console.WriteLine("Invalid GMT");
	}
	else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
	{
	    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
	} 
	else 
	{
	    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
	}

	for (int i = 0; i < times.Length; i++) 
	{
	    int newTime = ((times[i] + diff)) % 2400;
	    Console.WriteLine($"{times[i]} -> {newTime}");
	}
}

DisplayAdjustedTimes(schedule, 6, -6);


// METHOD SCOPE
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}


// RADIUS
double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) 
{
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}

void PrintCircleArea(int radius)
{
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}

void PrintCircleCircumference(int radius)
{
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}


// PASS VARIABLE BY VALUE OR REFERENCE
int a = 3;
int b = 4;
int c = 0;

Multiply(a, b, c);
Console.WriteLine($"global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) 
{
    c = a * b;
    Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
}
