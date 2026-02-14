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

                DisplayUserInfo(userName, userNumber);

                int result = CalculateResult(userNumber);

                Console.WriteLine($"\nCalculated result: {result}");
            }
        }
    }
}
