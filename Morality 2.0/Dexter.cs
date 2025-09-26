using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morality_2._0
{
    using System;

    class Dexter
    {
        public int DarkMorality { get; set; }
        public int LightMorality { get; set; }
        public int NeutralMorality { get; set; }

        public Dexter()
        {
            DarkMorality = 0;
            LightMorality = 0;
            NeutralMorality = 0;
        }

        public void UpdateMorality(string moralityEffect)
        {
            switch (moralityEffect)
            {
                case "Dark": DarkMorality++; break;
                case "Light": LightMorality++; break;
                case "Neutral": NeutralMorality++; break;
            }
        }

        public void DisplayMorality()
        {
            Console.WriteLine("\n--- Morality Status ---");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Dark Passenger: {DarkMorality}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Light Passenger: {LightMorality}");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Neutral Passenger: {NeutralMorality}");
            Console.ResetColor();
        }
    }//colors of morality bar en morality system
}

