string? readResult;
bool validEntry = false;

Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

// ----------------------------------------------------------
// ----------------------------------------------------------
// ----------------------------------------------------------
// CODE PROJECT 1 - write code that validates integer input

string? inputStr;
bool isValid = false;
int n = 0;

Console.WriteLine("Enter an integer between 5 to 10");
do
{
    inputStr = Console.ReadLine();
    if (inputStr == null) continue;

    isValid = int.TryParse(inputStr, out n);

    if (!isValid)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }

    if (n < 6 || n > 9)
    {
        isValid = false;
        Console.WriteLine($"You entered {n}. Please enter a number between 5 and 10.");
        continue;
    }

    Console.WriteLine($"Your input value ({inputStr}) has been accepted.");
        
} while (!isValid);
