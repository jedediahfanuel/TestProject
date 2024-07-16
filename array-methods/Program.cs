﻿
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

string[] paallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(paallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {paallets.Length}");
foreach (var paallet in paallets)
{
    Console.WriteLine($"-- {paallet}");
}

Console.WriteLine("");
Array.Resize(ref paallets, 6);
Console.WriteLine($"Resizing 6 ... count: {paallets.Length}");

paallets[4] = "C01";
paallets[5] = "C02";

foreach (var paallet in paallets)
{
    Console.WriteLine($"-- {paallet}");
}

Console.WriteLine("");
Array.Resize(ref paallets, 3);
Console.WriteLine($"Resizing 3 ... count: {paallets.Length}");

foreach (var paallet in paallets)
{
    Console.WriteLine($"-- {paallet}");
}


