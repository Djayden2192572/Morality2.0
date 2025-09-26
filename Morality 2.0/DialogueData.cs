using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morality_2._0
{
    using System.Collections.Generic;

    class DialogueData
    {
        public static Dictionary<string, Dialogue> GetStory()
        {
            return new Dictionary<string, Dialogue>
        {
            { "Start", new Dialogue(
                "Tonight's the night. The Trinity Killer must be stopped. What do you do?",
                new string[] { "Investigate the Trinity Killer", "Act immediately", "Ignore him and focus on Rita", "Tell Brian about him" },
                new string[] { "Neutral", "Dark", "Light", "Neutral" },
                new string[] { "Investigate", "Act", "Ignore", "Tell" }
            )},

            { "Act", new Dialogue(
                "You Decide to act immediately,as you track down trinity's address. What Will you do?",
                new string[] {"Go to his house immediately", "wait for him to leave","Leak his address to the police"},
                new string[] {"Dark", "Neutral", "Neutral" },
                new string[] {"Go","Wait", "Leak Address"}
             )},
            { "Leak Address", new Dialogue(
                "You leak trinity's address to miami metro. they investigate and come very close to catching him. what do you do?",
                new string[] {"Let them catch him", "Kill him yourself"},
                new string[] {"Light", "Dark" },
                new string[] {"Leave the hunt","Hunt on your own"}
             )},
            { "Leave the hunt", new Dialogue(
                "You leave it up to miami metro PD. they do catch him and have him jailed but due to inconclusive evidence he is only in prison for 10 years. When he gets out...",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
            { "Hunt on your own", new Dialogue(
                "You try to hunt trinity by delaying miami metro PD's investigation. You end up with nothing and so does miami metro as Trinity gets away.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
            { "Wait", new Dialogue(
          "You wait for him to leave his house and follow him. He leads you to his next target. What do you do?",
              new string[] { "Intervene immediately", "Alert the police" },
              new string[] { "Dark", "Light" },
              new string[] { "Intervene", "Alert Police" }
            )},
             { "Intervene", new Dialogue(
                "You Intervene and kill trinity, but his target sees you and you end up on the run.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
             { "Alert Police", new Dialogue(
                "You alert the police department and they take action by imprisoning trinity, however they cant keep him for long due to inconclusive evidence eventually letting him go.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},

             { "Go", new Dialogue(
                "You decide to go immediately to trinity's house.. while there, you see him abusing his family. what do you do?",
                new string[] {"Try and save the family first", "Go in for the kill." },
                new string[] {"Light", "Dark" },
                new string[] {"Save The Family", "Killshot",}
               )},
             { "Save The Family", new Dialogue(
                "You try to save the family by going for trinity when he's alone but he instead surprises and kills you.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
              { "Killshot", new Dialogue(
                "You go in immediately, killing trinity in front of his family. they are thankful at first but later report the murder to the police, incriminating your identity.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},

            { "Ignore", new Dialogue(
         "You ignore him and focus on Rita, deciding to spend time with her and the kids. However, you soon learn that Trinity has struck again. What do you do?",
                 new string[] { "Change your mind and pursue him", "Stay with Rita and let the police handle it" },
                 new string[] { "Dark", "Light" },
                 new string[] { "Pursue", "Stay",}
            )},
            { "Stay", new Dialogue(
         "You just stay with rita trusting your friends in miami metro to do the job for you. They don't find trinity so he does end up getting away.",
                 new string[] { },
                 new string[] { },
                 new string[] { }
            )},

             { "Pursue", new Dialogue(
         "You decide to change your mind and pursue trinity. you have the chance to kill him or learn from his ways as a family man. What do you do?",
                 new string[] { "Kill Him", "Get closer to him and observe his ways." },
                 new string[] { "Dark", "Neutra;" },
                 new string[] { "Murder", "Observe",}
            )},
              { "Murder", new Dialogue(
                "You discreetly sneak up and inject him with M99. You manage to kill him and throw the garbage bag into the ocean and so you live to kill another day.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
               { "Observe", new Dialogue(
                "You Stalk and observe his ways but along the way unbeknownst to you, he notices you. after you saw him murder an innocent child you go home to prepare to kill him... but there you find rita.. dead.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},


            { "Tell", new Dialogue(
                "You tell Brian about Trinity. He insists on murdering him just because of the danger he embodies. What do you do?",
                 new string[] { "Help Brian", "Convince him to back off"},
                 new string[] { "Dark", "Light", },
                 new string[] { "Help", "Back Off" }
            )},
              { "Help", new Dialogue(
                "You decide helping brian is the best course of action. you end up killing trinity but the manner in which causes the news to report the resurgence of the bay harbour butcher and the ice truck killer. what do you do?",
                 new string[] { "Stay in Miami", "Leave miami with brian"},
                 new string[] { "Light", "Dark", },
                 new string[] { "Miami", "Vacation" }
            )},
               { "Miami", new Dialogue(
                "You stay in miami but eventually brian is caught. He sacrifices himself for you saying he's both the killers, he's sentenced to death.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
               { "Vacation", new Dialogue(
                "You decide to leave miami with brian... leaving everything and everyone behind. Debra, Rita, Cody, Astor, Batista, Masuka, Miami PD, The Slice of Life.. all left behind.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
               { "Back Off", new Dialogue(
                "You tell brian to back off your case. He concedes.. for now. what will you do?",
                 new string[] { "Go after trinity", "Do Nothing"},
                 new string[] { "Dark", "Light", },
                 new string[] { "Chase Trinity", "Whole Lotta Nothing" }
            )},
               { "Whole Lotta Nothing", new Dialogue(
                "You decide to do nothing therefore pissing brian off. he goes in alone and murders trinity in cold blood. The danger has passed but your brother's impulsivity is made clear to you.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
                { "Chase Trinity", new Dialogue(
                "You go after trinity chopping him up perfectly without much difficulty although brian is in the back in your mind..",
                new string[] { },
                new string[] { },
                new string[] { }
            )},

            { "Investigate", new Dialogue(
                "You decide to investigate the Trinity Killer. As you search for clues, you stumble upon a hidden compartment with a mysterious item.",
                new string[] { "Take the mysterious item", "Leave it alone", "Search for more clues" },
                new string[] { "Neutral", "Dark", "Light" },
                new string[] { "ItemTaken", "LeaveItem", "MoreClues" }
            )},
            { "MoreClues", new Dialogue(
                "You search for more clues inside trinity/s house and you see an urn with the name Vera Mitchell. what do you do?.",
                new string[] { "Take the vase ", "Break the vase", "Leave it alone" },
                new string[] { "Neutral", "Dark", "Light" },
                new string[] { "Vasesteal", "Breaking", "Leavealone" }
            )},

             { "Vasesteal", new Dialogue(
                "You steal the vase and get out of his house. the moment he notices the vase's dissapearance he immediately starts abusing his family becoming an uncontrollabe projectile.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},

            { "Breaking", new Dialogue(
                "You break the vase and it shatters in a million pieces. in an instant when you turn around trinity is already strangling you, filled with rage. he strangles you..",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
             { "Leavealone", new Dialogue(
                "You leave the vase alone but trinity catches you and you narrowly escape,you decide trinity is far too dangerous and close and therefore back off..",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
             { "LeaveItem", new Dialogue(
                "You leave the key and eventually see trinity's son what do you do?",
                new string[] { "Take Him hostage", "Kill Him", "Leave"},
                new string[] { "Neutral", "Dark", "Neutral" },
                new string[] { "Hostage", "Bisect","Abandon" }
             )},

            { "ItemTaken", new Dialogue(
                "You take the mysterious item, which turns out to be a key to a secret safehouse. This gives you an advantage in your investigation.",
                new string[] { "Use the key to access the safehouse"},
                new string[] { "Neutral", },
                new string[] { "UsedKey", }
            )},

            { "UsedKey", new Dialogue(
                "You use the mysterious key and access the safehouse. You find Trinity unguarded and unaware of your presence.",
                new string[] { "Kill Trinity", "Let him go", "Report his safehouse to the authorities" },
                new string[] { "Dark", "Light", "Neutral" },
                new string[] { "KilledTrinity", "Lethimgo", "Reporthim" }
            )},

            { "KilledTrinity", new Dialogue(
                "You kill Trinity and uphold the code.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},

            { "Lethimgo", new Dialogue(
                "You let Trinity go, and he continues his crimes.",
                new string[] { },
                new string[] { },
                new string[] { }
            )},
            };
        }
    }
}
        
    

