using System;


namespace NumberGuesser
{
    //MAin class
    class Program
    {

        // static refers to the class itself rather than the object, same like in JS
        static void Main(string[] args)
        {

            GetAppInfo(); // Run GetAppInfo function to get info

            GreetUser(); // Ask for users name and greet

            while (true)
            {

                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                // Init correct number
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "CORRECT!! You guessed it!");

                // Ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
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

        static void GetAppInfo()
        {
            string appName = "Number guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Stas";

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome to {0}, version {1} made by {2} ", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            string inputName;

            Console.WriteLine("Identify yourself: ");

            inputName = Console.ReadLine();

            Console.WriteLine("Alright, {0}, let's play a game...", inputName);

        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
