using System;

class Person
{
    public static void Main()
    {
        GetUserNameAndLocation();
        ChristmasCountdown();
        GlazerApp.RunExample();
        Console.WriteLine("Press any key to quit...");
        Console.ReadKey();
    }
    static void GetUserNameAndLocation()
    {
        
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine("Hi " + name + "! Where are you from? ");
        string location = Console.ReadLine();
        Console.WriteLine("I have never been to " + location + ". I bet it is nice. Press any key to continue...");
        Console.ReadKey();
    }

    static void ChristmasCountdown()
    {
        DateTime today = DateTime.Today; ;
        Console.WriteLine("Today's date is: " + today.ToString("dd/MM/yyyy"));
        DateTime christmas = new DateTime(2022, 12, 25);
        TimeSpan daysUntil = christmas - today;
        Console.WriteLine("There are " + daysUntil.Days + " days until Christmas!");
    }
}