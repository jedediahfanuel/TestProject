Random rand = new Random();
int hero = 10;
int mons = 10;
bool swt = false;
int damage = 0;

do
{
	swt = !swt;
	damage = rand.Next(1,10);
	switch (swt)
	{
		case true:
			mons -= damage;
			Console.WriteLine($"Monster was damaged and lost {damage} health and now has {mons} health.");
			break;
		case false:
			hero -= damage;
			Console.WriteLine($"Hero was damaged and lost {damage} health and now has {hero} health.");
			break;
	}
} while (hero > 0 && mons > 0);

Console.WriteLine(swt ? "Hero wins!" : "Monster wins!");

// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
