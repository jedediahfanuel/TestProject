﻿bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");


// Simplify Code Blocks
bool flagz = true;
if (flagz)
{
    Console.WriteLine(flagz);
}

bool flagx = true;
if (flagx)
    Console.WriteLine(flagx);


// Oneliner if
bool dlag = true;
if (dlag) Console.WriteLine(dlag);


// Keeps the code readibily
string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");
