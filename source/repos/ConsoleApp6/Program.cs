// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

//Hotel Reservation
//Input name of guest, number of guests, with breakfast,date of reservation
//print guest list

string guest;
int numberofguests;
string withbreakfast = "";
bool breakfast = true;
int year;
int month;
int day;
DateTime startdt;
DateTime enddt = new DateTime();

Console.Write("Name of primary guest: ");
guest = Console.ReadLine();
Console.Write("Number of guests: ");
numberofguests = Convert.ToInt32(Console.ReadLine());
while (breakfast)
{
    Console.Write("With breakfast [Y/N]: ");
    withbreakfast = Console.ReadLine();
    withbreakfast = withbreakfast.ToUpper();

    if (withbreakfast == "Y" || withbreakfast == "N")
    {
        breakfast = false;
        if (withbreakfast == "Y")
        {
            withbreakfast = "with breakfast";
        }
        else
        {
            withbreakfast = "without breakfast";
        }
    }
    else
    {
        Console.WriteLine("Input valid response (Y/N");
    }
}
Console.Write("Date of Check In: [yyyy]");
year = Convert.ToInt32(Console.ReadLine());
Console.Write("Date of Check In: [mm]");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Date of Check In: [dd]");
day = Convert.ToInt32(Console.ReadLine());
startdt = new DateTime(year, month, day);
Console.Write("Date of Check Out: [yyyy]");
year = Convert.ToInt32(Console.ReadLine());
Console.Write("Date of Check Out: [mm]");
month = Convert.ToInt32(Console.ReadLine());
Console.Write("Date of Check Out: [dd]");
day = Convert.ToInt32(Console.ReadLine());
enddt = new DateTime(year, month, day);

Console.WriteLine($"Welcome {guest}!");
Console.WriteLine($"You have reserved a room for {numberofguests} guests.");
Console.WriteLine($"Your room will come {withbreakfast}.");
Console.WriteLine($"You will check in at {startdt} and check out on {enddt}");









