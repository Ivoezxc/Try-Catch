using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter a non-negative integer: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number) && number >= 0)
            {
                double squareRoot = Math.Sqrt(number);
                Console.WriteLine($"The square root of {number} is: {squareRoot:F2}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Goodbye!");
        }
    }
}
