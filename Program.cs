using System;

namespace NumberGeusser
{
    class Program
    {
        static void Main(string[] args)
        {
            
                //Method to show app info
                GetAppInfo();

                // Method to great user
                GreatUser();
            while (true)
            {
                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // int correctNumber = 7;

                // Create a new random object 
                Random random = new Random();

                // Init correct Number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                while (correctNumber != guess)
                {
                    // Get user input
                    string inputNumber = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(inputNumber, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "It's not a number , Please Enter Number!");

                        // keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(inputNumber);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColor(ConsoleColor.Red, "Wrong Number , please try again");
                    }
                }
                PrintColor(ConsoleColor.Yellow, "YOU'RE CORRECT!");

                // Reset ForegroundColor 
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        //Method to show app info
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Guess Number";
            string appVersion = "1.0.0.0";
            string appAuthor = "Mahmoud Faragallah";

            // Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out App info 
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color 
            Console.ResetColor();
        }

        static void GreatUser()
        {
            // Ask user for name 
            Console.WriteLine("What's your name?");

            // Take a name into string variable
            string InputName = Console.ReadLine();

            // Offer a game
            Console.WriteLine("Hello {0} let's play a game !", InputName);
        }
        static void PrintColor(ConsoleColor color, string message)
        {
            // change ForegroundColor 
            Console.ForegroundColor = color;

            // Tell user that's wrong number 
            Console.WriteLine(message);

            // Reset ForegroundColor 
            Console.ResetColor();
        }
    }
}
