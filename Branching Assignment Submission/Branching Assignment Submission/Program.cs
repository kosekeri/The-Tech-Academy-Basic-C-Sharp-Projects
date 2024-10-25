using System;

class Program
{
    static void Main()
    {
        // Welcome message displayed to the user
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the package weight exceeds the limit
        if (weight > 50)
        {
            // Display error message and exit the program if weight is too heavy
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End the program
        }

        // Prompt the user to enter the package dimensions
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the total dimensions exceed the limit
        if (width + height + length > 50)
        {
            // Display error message and exit the program if dimensions are too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End the program
        }

        // Calculate the volume of the package and the shipping quote
        double quote = (width * height * length * weight) / 100;

        // Display the estimated shipping quote to the user
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank you message
        Console.WriteLine("Thank you!");
    }
}
