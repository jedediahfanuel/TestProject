
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


// SPLIT && JOIN
Console.WriteLine("\n\n SPLIT && JOIN");
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

Console.WriteLine("\n Split()");
string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}


Console.WriteLine("\n");

// CHALLENGE 1 : PANGRAM
string pangram = "The quick brown fox jumps over the lazy dog";
char[] charay = pangram.ToCharArray();
Array.Reverse(charay);
Console.WriteLine(String.Join("", charay));
