string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Sencond: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

// Initializing array
string[] fraudulentOrderIds = { "A123", "B456", "C789" };

Console.WriteLine($"First: {fraudulentOrderIds[0]}");
Console.WriteLine($"Sencond: {fraudulentOrderIds[1]}");
Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

fraudulentOrderIds[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

Console.WriteLine("");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent order to process.");

Console.WriteLine("\n\n\n");

Console.WriteLine("// --------------------------------------------------------------\n");
// --------------------------------------------------------------
// --------------------------------------------------------------

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
	Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
	sum += items;
	bin++;
	Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory");
