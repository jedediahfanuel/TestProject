// First Exercise - FLIP COIN
Random coin = new Random();
int flip = coin.Next(0,2);
Console.WriteLine((flip == 0) ? "heads" : "tails");

// Second Exercise - DECISION LOGIC
string permission = "Admin|Manager";
int level = 55;

string message = permission.Contains("Admin"  ) && level >  55 ? "Welcome, Super Admin user." 
               : permission.Contains("Admin"  ) && level <= 55 ? "Welcome, Admin user."
			   : permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access."
			   // : permission.Contains("Manager") && level <  20 ? 
			   : "You don't have sufficient privileges.";

Console.WriteLine(message);

