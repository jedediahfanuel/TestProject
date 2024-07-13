string[] fraudOIDs = {
	"B123",
    "C234",
    "A345",
     "C15",
    "B177",
   "G3003",
    "C235",
    "B179"
};

foreach (string OID in fraudOIDs)
{
	if (OID.StartsWith("B"))
	{
		Console.WriteLine(OID);
	}
}
