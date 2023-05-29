


//using ConsoleApp_Practice;

/*Console.WriteLine("\t Which Size of Shirt you want ");
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
    Console.WriteLine("Thnks for visit our shop");*/


/*Console.WriteLine("\t .........What day is Today ..........");
Console.WriteLine("Select a number from 7 days off week it will show you the day name");
int input =Convert.ToInt32(Console.ReadLine());
DayOfWeek day1 = DayOfWeek.Sunday;
DayOfWeek day2 = DayOfWeek.Monday;
DayOfWeek day3 = DayOfWeek.Tuesday;
DayOfWeek day4 = DayOfWeek.Wednesday;
DayOfWeek day5 = DayOfWeek.Thursday;
DayOfWeek day6 = DayOfWeek.Friday;
DayOfWeek day7 = DayOfWeek.Saturday;

switch (input)
{
    case 1:
        Console.WriteLine("Today is Sunday");
        break;
    case 2:
        Console.WriteLine("Today is Monday");
        break;
    case 3:
        Console.WriteLine("Today is Tuesday");
        break;
        case 4:
        Console.WriteLine("Today is Wednesday");
        break;
        case 5:
        Console.WriteLine("Today is Thursday");
        break;
        case 6:
        Console.WriteLine("Today is Friday");
        break;
        case 7:
        Console.WriteLine("Today is Saturday");
        break;
    default:
        Console.WriteLine("You enter a number out off week days");
        break;
}


*/

/*
DayOfWeek days = DayOfWeek.Friday;
Console.WriteLine($"Today is {days}");*/
/*Type days = typeof(DayOfWeek);
string[] DayOfWeek = Enum.GetNames(days);
*/

/*
using ConsoleApp_Practice;



Console.WriteLine("Enter Date to see whats the season is going on (yyyy-mm-dd)");
DateTime input =Convert.ToDateTime( Console.ReadLine());
int month = input.Month;

if (month < 2 || month == 12)
{
    Console.WriteLine($"The season is going on {season.Winter}");
}
else if (month > 2 || month <= 5)
{
    Console.WriteLine($"The season is going on {season.Spring}");
}
else if (month > 6 || month <= 8)
{
    Console.WriteLine($"The season is going on {season.Summer}");
}
else
{
    Console.WriteLine($"The season is going on {season.Autumn}");
}
*/
using ConsoleApp_Practice;


Console.WriteLine("............Well Come Ahmed's Calculator..........");
Console.Write(" Enter First value >>");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter First value >>");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The four basic operators.witch you want to use \n 1 - {Operation.addition} \n 2 - {Operation.subtraction} \n 3 - {Operation.multiplication} \n 4 - {Operation.division}");
int userSlection =Convert.ToInt32( Console.ReadLine());

if (userSlection == 1)
{
    Console.WriteLine($"Your result is {value1 + value2}");
}
else  if (userSlection == 2)
{
    Console.WriteLine($"Your result is {value1 - value2}");
}
else  if (userSlection == 3)
{
    Console.WriteLine($"Your result is {value1 * value2}");
}
else if (userSlection == 4)
{
    Console.WriteLine($"Your result is {value1 / value2}");

}
else 
{
    Console.WriteLine("you are Selecting a rong number");
}