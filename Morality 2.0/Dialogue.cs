using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morality_2._0
{
    using System;

    class Dialogue
    {
        public string Text { get; }
        public string[] Options { get; }
        public string[] MoralityEffects { get; }
        public string[] Branch { get; }

        public Dialogue(string text, string[] options, string[] moralityEffects, string[] branch)
        {
            Text = text;
            Options = options;
            MoralityEffects = moralityEffects;
            Branch = branch;
        }

        public void Display(int dialogueCount)
        {
            Console.WriteLine(Text);

            // Always display all options
            for (int i = 0; i < Options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Options[i]}");
            }
        }
    }
}
