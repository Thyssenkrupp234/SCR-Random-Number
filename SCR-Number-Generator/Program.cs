using System;
namespace SCR_Number_Generator
{
    class Program
    {
        public static string[] trains = { "HST", "HST (5 car)", "HST (Buffer)", "68", "143", "143 (Double)", "158/0", "158/9", "165/0", "165/1", "166", "168", "170", "171", "195/0", "195/1", "195/2", "220", "221", "319", "321", "331/0", "331/1", "332 (4 car)", "332 (5 car)", "333", "350", "357", "360/1", "360/2", "380/0", "380/1", "465", "508", "707", "717", "720", "730/0", "730/1", "801", "802" };

        static void Main(string[] args)
        {
            Console.WriteLine("Choose an option");
            Console.Write("1. Generate a random number between x and y");
            Console.Write("\n2. Choose a random SCR train\n\n");
            Console.Write("Enter your choice here: ");

            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                int maxValue = int.MaxValue - 1;
                Console.Clear();
                Console.Write("Please input a minimum number: ");
                int input_min = int.Parse(Console.ReadLine());
                Console.Write("\nPlease input a maximum number (max number is " + maxValue + "): ");
                int input_max = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Number generated is " + new Random().Next(input_min, input_max + 1));
                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
            }
            if (option == 2)
            {
                Console.Clear();
                Console.Write("\nRandom train chosen is: class " + trains[new Random().Next(0, trains.Length)]);
                Console.WriteLine("\nPress enter to continue...");
                Console.ReadLine();
            }
        }
    }
}