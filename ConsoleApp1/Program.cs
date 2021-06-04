using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string centerText = "Guess the number game";
            string bottomText = "Press any key to continue...";
            int centerX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write(centerText);
            int bottomX = (Console.WindowWidth / 2) - (centerText.Length / 2);
            int bottomY = Console.WindowHeight;
            Console.SetCursorPosition(bottomX, bottomY);
            Console.Write(bottomText);
            Console.ReadKey();
            Console.Clear();
            Random randomize = new Random();
            int gNum = randomize.Next(0, 100);
            Console.Write("I made a number from 0 to 100. Guess it. " +
                              "\nEnter number: ");
            int uNum = int.Parse(Console.ReadLine());
            while (uNum != gNum)
            {
                if (uNum < gNum)
                {
                    Console.WriteLine("\nYou entered too small a number, try to take more.\n");
                }
                else if (uNum > gNum) Console.WriteLine("\nYou entered too large a number, try to take a smaller one.\n");
                Console.Write("Enter number: ");
                uNum = int.Parse(Console.ReadLine());
            }
            if (uNum == gNum) Console.WriteLine("\n\nYES! You won!");
            Console.SetCursorPosition(bottomX, bottomY);
            Console.Write(bottomText);
        }
    }
}