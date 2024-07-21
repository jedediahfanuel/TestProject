﻿Console.WriteLine("Before calling a method");
SayHello();
Console.WriteLine("After calling a method");

void SayHello() 
{
    Console.WriteLine("Hello World!");
}

int[] a = {1,2,3,4,5};

Console.WriteLine("Contents of Array:");
PrintArray();

void PrintArray()
{
    foreach (int x in a)
    {
        Console.Write($"{x} ");
    }
    Console.WriteLine();
}

// Use concise naming
void ShowData(string a, int b, int c){};
void DisplayDate(string month, int day, int year){};


Console.WriteLine("\n\n")

// EXERCISE 1 - Create Method that Displaying Random Number
Console.WriteLine("Generating random numbers:");
DisplayRandomNumbers();

void DisplayRandomNumbers() 
{
    Random random = new Random();

    for (int i = 0; i < 5; i++) 
    {
        Console.Write($"{random.Next(1, 100)} ");
    }

    Console.WriteLine();
}
