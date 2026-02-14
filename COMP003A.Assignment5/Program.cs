namespace COMP003A.Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this loop let the user repeat the program based on the input
            string runAgain = "y";

            // repeats as long as the user chooses y
            while (runAgain == "y")
            {
                DisplayIntroduction();

                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();

                Console.Write("Enter a whole number: ");
                int userNumber = int.Parse(Console.ReadLine());

                // uses parameters instead of accessing Main variable directly
                DisplayUserInfo(userName, userNumber);

                // it returns a value
                int result = CalculateResult(userNumber);

                Console.WriteLine($"\nCalculated result: {result}");

                // Decision of the results
                if (result > 10)
                {
                    Console.WriteLine("The result is greater than 10");
                }
                else
                {
                    Console.WriteLine("The result is 10 or less");
                }

                Console.Write("\nWould you like to run the program again (y/n): ");
                runAgain = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Program anded");
        }

        // it keeps the introduction organized
        static void DisplayIntroduction()
        {
            Console.WriteLine("Welcome to the Program!\n");
        }

        // demostrates passing data using parameters
        static void DisplayUserInfo(string name, int number)
        {
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"You entered: {number}");
        }

        // it performs a calculation and raturn a value to Main

        static int CalculateResult(int number)
        {
            int calculateValue = number * 2;
            return calculateValue;
        }
    }
}
