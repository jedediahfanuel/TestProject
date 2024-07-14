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

// ----------------------------------------------------------
// ----------------------------------------------------------
// ----------------------------------------------------------
// CODE PROJECT 2 - write code that validates string input

string? inpStr= "";
string[] roles = {"administrator", "manager", "user"};

Console.WriteLine("Enter you role name (Administrator, Manager, or User)");

do
{
    inpStr = Console.ReadLine();
    if (inpStr == null) continue;

    inpStr = inpStr.Trim().ToLower();

    string role = Array.Find(roles, r => inpStr == r);

    if (role == null)
    {
        Console.WriteLine($"The role name that you entered, \"{inpStr}\" is not valid.");
        continue;
    }

    Console.WriteLine($"Your input value ({role}) has been accepted.");
    break;
} while(true);


// --- 3rd
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
