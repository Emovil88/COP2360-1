P-4 Handling Division and Conversion Exceptions 
//Add More Detailed Error Messages or Logging

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        PerformDivision(input1, input2);

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static void PerformDivision(string input1, string input2)
    {
        try
        {
            int number1 = Convert.ToInt32(input1);
            int number2 = Convert.ToInt32(input2);

            int result = Divide(number1, number2);
            Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are too large.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
            Console.WriteLine("Stack Trace: " + ex.StackTrace);
        }
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}
