string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    Console.WriteLine($"{corporate[i,0].Substring(0,2).ToLower()}{corporate[i,1].ToLower()}@contoso.com");
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    Console.WriteLine($"{external[i,0].Substring(0,2).ToLower()}{external[i,1].ToLower()}@{externalDomain}");
}
