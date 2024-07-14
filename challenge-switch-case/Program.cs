// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = (product[0]) switch
{
	("01") => "Sweat shirt",
	("02") => "Sweat shirt",
	("03") => "Sweat shirt",
	_ => "Other"
};

string color = (product[1]) switch
{
	("BL") => "Black",
	("MN") => "Maroon",
	_ => "White"
};

string size = (product[2]) switch
{
	("S") => "Small",
	("M") => "Medium",
	("L") => "Large",
	_ => "One Size Fits All"
};

Console.WriteLine($"Product: {size} {color} {type}");

// // SKU = Stock Keeping Unit
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");
