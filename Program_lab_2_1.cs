using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            Random rand = new Random();

            string[,] colorGrid = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int colorIndex = rand.Next(1, 16);
                    colorGrid[i, j] = colors[colorIndex].ToString();
                    Console.ForegroundColor = colors[colorIndex];
                    Console.Write(colorGrid[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
