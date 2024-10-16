using System;
using System.Data;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter an arithmetic expression (or 'Q' to quit): ");
            string input = Console.ReadLine();

            if (input.Equals("Q", StringComparison.OrdinalIgnoreCase))
                break;

            try
            {
                var result = new DataTable().Compute(input, null);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid expression. Please try again.");
            }
        }
    }
}
