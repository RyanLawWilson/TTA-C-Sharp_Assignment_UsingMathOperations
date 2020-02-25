using System;

namespace UsingMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();     // Create 1 instance on random to make delays
            int additionalDelay = rand.Next(0, 301);    // Creats a random number between 0 and 300
            double number;      // Initialize the number that represents user input (made it easier to copy and pastes)

            // Multiply by 50
            Console.Write("Enter a number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Multiplying by 50");
            createDelay(rand);
            Console.WriteLine("Result: " + (number * 50).ToString() + "\n");

            // Add by 25
            Console.Write("Enter another number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Adding 25");
            createDelay(rand);
            Console.WriteLine("Result: " + (number + 25).ToString() + "\n");

            // Divide by 12.5
            Console.Write("Enter yet another number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dividing by 12.5");
            createDelay(rand);
            Console.WriteLine("Result: " + (number / 12.5).ToString() + "\n");

            // Is greater than 50?
            Console.Write("Enter a number, please: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Checking if > 50");
            createDelay(rand);
            Console.WriteLine("Result: " + (number > 50).ToString() + "\n");

            // Find remainder when divided by 7
            Console.Write("Enter a number, pretty please: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.Write("Dividing by 7 and getting remainder");
            createDelay(rand);
            Console.WriteLine("Result: " + (number % 7).ToString() + "\n");

            Console.WriteLine("Program Finished!  Press ENTER to exit...");
            Console.Read();
        }

        static void createDelay(Random rand)
        {
            short baseDelay = 150;
            short maxDelay = 400;
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.Write(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.Write(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(baseDelay + rand.Next(0, maxDelay + 1));
        }
    }
}
