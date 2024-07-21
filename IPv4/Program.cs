/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/
string ipv4Input = "107.31.1.5";
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

void ValidateLength()
{
	validLength = ipv4Input.Split(".").Length == 4
}

void ValidateZeroes()
{
	foreach (string number in ipv4Input)
	{
		if (number.Length > 1 && number.StartsWith("0"))
		{
			validZeroes = false;
			return;
		}
	}
	validZeroes = true;
}

void ValidateRange()
{
	foreach (string number in ipv4Input)
	{
		if (int.Parse(number) < 1 || int.Parse(number) > 255)
		{
			validRange = false;
			return;
		}
	}
	validRange = true;
}

if (ValidateLength() && ValidateZeroes() && ValidateRange()) 
{
    Console.WriteLine($"ip is a valid IPv4 address");
} 
else 
{
    Console.WriteLine($"ip is an invalid IPv4 address");
}
