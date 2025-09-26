using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morality_2._0
{
    using System;

    class Utility
    {
        public static void DisplayMoralityEffect(string moralityEffect, string option)
        {
            if (moralityEffect == "Dark")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou chose: {option} (Dark Passenger)");
            }
            else if (moralityEffect == "Light")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nYou chose: {option} (Light Passenger)");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\nYou chose: {option} (Neutral Passenger)");
            }
            Console.ResetColor();
        }
    }
}
//add the texts of you chose blank passenger through if statements
        
    
