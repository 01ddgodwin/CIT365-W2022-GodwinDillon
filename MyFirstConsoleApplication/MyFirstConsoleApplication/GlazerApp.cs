using System;

static class GlazerApp
{

    public static void RunExample()
    {
        Console.WriteLine("Width: ");
        var width = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Height: ");
        var height = Convert.ToInt32(Console.ReadLine());

        var woodLength = 2 * (width + height) * 3.25;
        var glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");
    }
}
