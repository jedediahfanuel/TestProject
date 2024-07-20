string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    // Note the overload of the Substring to return only the remaining 
    // unprocessed message:
    message = message.Substring(closingPosition + 1);
}

string gmessageg = "Help (find) the {opening Sym}";
Console.WriteLine($"Searching THIS gMessageg: {gmessageg}");
char[] openSym = { '[', '{', '(' };
int startPos = 5;
int openingPos = gmessageg.IndexOfAny(openSym);
Console.WriteLine($"Found WITHOUT using startPos: {gmessageg.Substring(openingPos)}");

openingPos = gmessageg.IndexOfAny(openSym, startPos);
Console.WriteLine($"Found WITH using startPos {startPos}:  {gmessageg.Substring(openingPos)}");
