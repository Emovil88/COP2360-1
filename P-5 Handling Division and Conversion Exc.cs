P-5 Handling Division and Conversion Exceptions 

//Experiment by Removing the Try-Catch Blocks

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        int result = Divide(number1, number2);
        Console.WriteLine($"The result of {number1} divided by {number2} is: {result}");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int Divide(int a, int b)
    {
        return a / b;
    }
}
