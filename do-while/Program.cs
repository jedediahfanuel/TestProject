// Do While
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

// While
Random randoms = new Random();
int curr = randoms.Next(1, 11);

while (curr >= 3)
{
    Console.WriteLine(curr);
    curr = randoms.Next(1, 11);
}
Console.WriteLine($"Last number: {curr}");

// Continue keyword
Random rand = new Random();
int cu = rand.Next(1, 11);

do
{
    cu = rand.Next(1, 11);

    if (cu >= 8) continue;

    Console.WriteLine(cu);
} while (cu != 7);
