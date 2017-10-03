using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {             
            int choice = 1;
            Program game = new Program();
            while (choice==1)
            {
                choice = game.GuessingGame();
            }
            Console.WriteLine("You have exited from the game.");
            Console.Read();
        }
        public int GuessingGame()
        {
            Console.WriteLine("\t\t\t* * * Guessing Game * * *\n\n" +
                "Try to guess the hidden number." +
                " Enter a number to start.\n\n\t\t\tYou have got seven guesses.\n\n");
            Random rnd = new Random();
            int hiddenNumber = rnd.Next(0, 11);
            int correct = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"{7-i} guesses left");
                Console.Write("Enter a number between 0 and 10:");
                string input = Console.ReadLine();
                int value;
                bool isValid = int.TryParse( input, out  value);
                if (value == hiddenNumber)
                {
                    correct = 1;
                    break;
                }
                else if (value < 0 || value > 10)
                {
                    Console.WriteLine("Not in range.Try again.");
                }
                else if (value>0&&value<11 && value != hiddenNumber)
                {
                    Console.WriteLine("Wrong! Try again!");
                }
                else if (isValid == false)
                {
                    Console.WriteLine("Invalid input!");
                    correct = 3;
                    break;
                }
            }
            if (correct==1)
            {
                Console.WriteLine("Congratulations!!! You won!!!!!!!");
            }
            else
            {
                Console.WriteLine("Game over. You lost.");
            }            
            Console.WriteLine("\n\nIf you want to play again press '1', else press anything.\n");
            string choiceInput = Console.ReadLine();
            int choice;
            bool secondIsValid = int.TryParse(choiceInput, out choice);
            if (secondIsValid && choice==1)
            {
                Console.Clear();
                return choice;
            }
            else 
            {
                return 0;
            }
                      
        }
    }
}
