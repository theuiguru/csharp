using System; //using bringing other namespaces

namespace NumberGuesser //namespace: container for classes and functions
{
    //Main class
    class Program //class: create objects from and inside methods (functions) and properties
    {
        //Entry point method
        //static: no instances referring to the function itself
        //void: return type not going to return anything
        static void Main(string[] args)
        {
            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for user's name and greet

            while (true)
            {
                //Init correct number
                //int correctNumber = 7;

                //Create a new random object
                Random random = new Random();

                //Init correct number
                int correctNumber = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get user's input
                    string input = Console.ReadLine();

                    //Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                //Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                } else if(answer == "N")
                {
                    return;
                } else
                {
                    return;
                }
            }
            Console.Read();
        }

        //Get and display app info
        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Chris Thomas";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset Text Color
            Console.ResetColor();
        }

        //Ask user's name and greet
        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user it's not a number
            Console.WriteLine(message);

            //Reset Text Color
            Console.ResetColor();
        }
    }
}
