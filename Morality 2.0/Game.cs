namespace Morality_2._0
{
    internal class Game
    {
        public static string currentDialogueId = "Start";
        static Dexter dexter = new Dexter();
        static Inventory playerInventory = new Inventory();

        public static Dictionary<string, Dialogue> story = DialogueData.GetStory();

        // Add the Start method
        public void Start()
        {
            int dialogueCount = 0;
            while (true)
            {
                Dialogue currentDialogue = story[currentDialogueId];
                PlayDialogue(currentDialogue, ref dialogueCount);
            }
        }

        private static void PlayDialogue(Dialogue dialogue, ref int count)
        {
            dialogue.Display(count);

            string choice = Console.ReadLine();

            if (int.TryParse(choice, out int option) && option >= 1 && option <= dialogue.Options.Length)
            {
                string moralityEffect = dialogue.MoralityEffects[option - 1];
                dexter.UpdateMorality(moralityEffect);

                // Example: Special item acquisition
                // Check if the key is already in the inventory before adding it
                if (option == 1 && !playerInventory.HasItem("Mysterious Key"))
                {
                    playerInventory.AddItem("Mysterious Key");
                }


                // Display morality effect with color
                Utility.DisplayMoralityEffect(moralityEffect, dialogue.Options[option - 1]);

                string nextDialogueId = dialogue.Branch[option - 1];
                if (story.ContainsKey(nextDialogueId))
                {
                    currentDialogueId = nextDialogueId;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Error: The branch '{nextDialogueId}' is not defined. Returning to start.");
                    Console.ResetColor();
                    currentDialogueId = "Start"; // Go back to the start
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                PlayDialogue(dialogue, ref count); // Retry current dialogue
            }

            dexter.DisplayMorality();
            playerInventory.DisplayInventory();
        }
    }
}

