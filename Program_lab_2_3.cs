using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Enter the number of rows: ");
            int numRows = int.Parse(Console.ReadLine());

            char[][] jaggedArray = new char[numRows][];
            List<Dictionary<char, int>> letterCounts = new List<Dictionary<char, int>>();

            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Enter the number of elements in row {i + 1}: ");
                int numElements = int.Parse(Console.ReadLine());

                jaggedArray[i] = new char[numElements];
                Dictionary<char, int> letterCount = new Dictionary<char, int>();

                for (int j = 0; j < numElements; j++)
                {
                    char randomLetter = (char)rand.Next('A', 'Z' + 1);
                    jaggedArray[i][j] = randomLetter;

                    if (letterCount.ContainsKey(randomLetter))
                        letterCount[randomLetter]++;
                    else
                        letterCount[randomLetter] = 1;
                }

                Console.WriteLine($"Row {i + 1}: {string.Join(" ", jaggedArray[i])}");
                letterCounts.Add(letterCount);
            }

            for (int i = 0; i < numRows; i++)
            {
                Console.WriteLine($"Letter counts for row {i + 1}:");
                foreach (var entry in letterCounts[i])
                {
                    Console.WriteLine($"{entry.Key}: {entry.Value}");
                }
            }
        }
    }
}
