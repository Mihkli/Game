using System;

namespace KevinMihkli
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            Greetuser();

            while (true)
            {

                Random random = new Random();

                int correctnum = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctnum)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        PrintColormessage(ConsoleColor.Red, "Please use an actual number");
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctnum)
                    {

                        PrintColormessage(ConsoleColor.Red, "Wrong Number, try again");
                    }

                }

                PrintColormessage(ConsoleColor.Green, "You are CORRECT!!!");

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

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appversion = "1.0.0";
            string appauthor = "Kevin Mihkli";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0}: version {1} by {2}", appName, appversion, appauthor);

            Console.ResetColor();
        }
        static void Greetuser()
        {
            Console.WriteLine("What's your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game..", inputName);
        }
        static void PrintColormessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }


}
   


