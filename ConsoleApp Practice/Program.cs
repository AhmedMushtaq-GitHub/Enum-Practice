


using ConsoleApp_Practice;
Console.WriteLine("\t Which Size of Shirt you want ");
Console.WriteLine("1 : Small ");
Console.WriteLine("2 : Medium ");
Console.WriteLine("3 : Large ");
Console.WriteLine("4 : Extra_large ");
int input =Convert.ToInt32( Console.ReadLine());

Sizes sizesm = Sizes.small;
int sp = (int) Sizes.small;

Sizes sizem = Sizes.medium;
int mp = (int) Sizes.medium;

Sizes sizel = Sizes.large;
int lp = (int) Sizes.large;

Sizes sizexl = Sizes.extra_large;
int xlp = (int) Sizes.extra_large;


switch (input)
{
	case 1:
        Console.WriteLine($"Your Shirt size is : {sizesm} & Rs {sp}");
        break;

    case 2:
        Console.WriteLine($"Your Shirt size is : {sizem} & Rs {mp}");
        break;
    case 3:
        Console.WriteLine($"Your Shirt size is : {sizel} & Rs {lp}");
        break;
    case 4:
        Console.WriteLine($"Your Shirt size is : {sizexl} & Rs {xlp}");
        break;

    default:
        Console.WriteLine("Sorry we not have this one");
        break;
}
Console.WriteLine("Order Confirmed Yes/No");
string? input2 = Console.ReadLine().ToLower();
if (input2 == "yes")
{
    Console.WriteLine("Thanks for shoping your order is redy");
}
else
    Console.WriteLine("Thnks for visit our shop");