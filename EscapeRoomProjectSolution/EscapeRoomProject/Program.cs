using System;

namespace Start_Game_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo userKeyInput;
            bool keyPressedRight = false;

            while (!keyPressedRight)    //continues loop if condituion is not fullfilled
            {
                Console.WriteLine("Please press the Enter key to start the game or the Escape key to quit");
                userKeyInput = Console.ReadKey(true);

                //listents to the currrent key press
                if (userKeyInput.Key == ConsoleKey.Escape)  //if key press is Escape it terminates the task
                {
                    Console.WriteLine("Thanks for playing!");
                    keyPressedRight = true;
                }
                else if (userKeyInput.Key == ConsoleKey.Enter)  //if key press is Enter it executes the function StartGame()
                {
                    Console.WriteLine("START THE GAME");
                    keyPressedRight = true;
                    StartGame();
                }
            }
        }

        public static void StartGame()      //on call it ...
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("Testing");
        }
    }
}
