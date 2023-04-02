using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowMeTheMoney
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var logicEngine = new LogicEngine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("\t\t$\t\t\'SHOW ME THE MONEY!\'\t\t   $");
            Console.WriteLine("\t\t$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\t\tConvert numerals to dollar currency written in English.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nThis tool will convert any number between 0.01 and 10,000 to dollars and cents shown in English");
            Console.WriteLine("\nPlease enter the amount you wish to show as currency");

            string userInput = String.Empty;
            do
            {
                Console.Write("Amount: $");
                userInput = Console.ReadLine();

                //remove any whitespace
                userInput = userInput?.Trim();

                if (userInput?.ToLower() != "exit")
                {
                    if (userInput != null)
                    {
                        Console.WriteLine(logicEngine.ResponseBuilder(userInput));
                    }
                    Console.WriteLine("\nEnter another number or \'exit\' to quit");
                }

            }
            while (userInput?.ToLower() != "exit");
        }
    }
}
