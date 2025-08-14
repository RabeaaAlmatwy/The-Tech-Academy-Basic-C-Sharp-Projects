using System;

class Program
{
    static void Main()
    {
        // Display a welcome message at the start
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt for package weight
        Console.Write("Please enter the package weight: ");
        // Convert the user input from string to decimal
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too heavy
        if (weight > 50)
        {
            // Display error message and stop program if weight is too much
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exit the program
        }

        // Prompt for package width
        Console.Write("Please enter the package width: ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package height
        Console.Write("Please enter the package height: ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Prompt for package length
        Console.Write("Please enter the package length: ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Calculate total dimensions
        decimal dimensionTotal = width + height + length;

        // Check if the total dimensions exceed the limit
        if (dimensionTotal > 50)
        {
            // Display error message and stop program if dimensions are too large
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exit the program
        }

        // Calculate the volume
        decimal volume = width * height * length;

        // Calculate shipping quote
        decimal quote = (volume * weight) / 100;

        // Display the final shipping cost with two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
}
