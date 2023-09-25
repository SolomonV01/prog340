using System;
using static System.Console;

namespace Vidal_DungeonCrawler
{
    public class Game
    {
        public Player? player;
        
        private string? Name { get; set; }

        public void Run()
        {
            WriteLine("Who are you?");
            Name = ReadLine();
            player = new Player(Name);

            GameIntro();
        }

        public void GameIntro()
        {
            WriteLine("You fell asleep like you did any other night. Although you were tired, you'd fallen into your dreams faster than usual.\nAt first, you thought it was just basic lucid dreaming, but you soon realize that you're more conscious than you've ever been in a lucid dream.\nAfter breaking the first cardinal rule of dreams, 'don't acknowledge that you're dreaming in front of the people in your dream', you realize it isn't a dream at all.");

            WriteLine(" ");

            WriteLine("Press 'Enter' to continue...");
            ReadLine();
            Clear();
            NewEarth();
        }

        public void NewEarth()
        {
            string choice;

            ForegroundColor = ConsoleColor.Green;
            BackgroundColor = ConsoleColor.DarkGreen;
            WriteLine("    _   __                ______           __  __  \n   / | / /__ _      __   / ____/___ ______/ /_/ /_ \n  /  |/ / _ \\ | /| / /  / __/ / __ `/ ___/ __/ __ \\\n / /|  /  __/ |/ |/ /  / /___/ /_/ / /  / /_/ / / /\n/_/ |_/\\___/|__/|__/  /_____/\\__,_/_/   \\__/_/ /_/ \n                                                   ");

            ResetColor();
            WriteLine(" ");

            WriteLine("You look around a for a moment, realizing that your surroundings are familiar. It's Earth... but different. A magical kind of different.");


            WriteLine("\n'Hey! You!' someone whispers from behind you. You turn around, but you don't see anyone there.\n'Turn around!' You turn around and you see a... bug? \n'I know what you're thinking, I'm not a bug. I'm just small.' \nYou look closer and see it's a fairy dressed completely in blue.");

            WriteLine(" ");

            WriteLine("'I know you're not from around here so I can help you get back home. But first, what color do you think suits me best? Orange, Blue, or Pink?'");

            WriteLine(" ");

            Write("What color suits the fairy?: ");
            choice = ReadLine().ToLower();
            Clear();

            switch (choice)
            {
                case "Orange":
                case "orange":
                    {
                        WriteLine("'Orange?! What a hideous color! I hope you get lost!' The fairy yells at you before flying away, comical steam nearly fuming from their figure.\nThey were wearing blue, you notice. The color opposite of orange in terms of color theory...\nYou don't have much time to think before the ground crumbles from beneath you, swallowing you into an empty realm of darkness...");
                        Clear();
                        YouLose();
                        break;
                    }
                case "Blue":
                case "blue":
                    {
                        WriteLine("'Isn't it? It's my favorite color!' The fairy giggles.\n'Well... I'll help you out. The truth is, you've shifted into another reality. Don't sorry too much about the big details on what shifting is, you'll fry your brain on the way home. All you gotta know is, you have to get better at shifting to be able to navigate your way back home. Since you figured out what my best color is, I'll give you a shifting point. Think of it like EXP or something. Anyways... best of luck to you and your great fashion sense!'\nThe fairy flies away, bidding you a kind farewell.");

                        WriteLine(" ");

                        WriteLine("You feel a surge of power, your mind seeming to clear like there had been a dense fog around. The sky beams a bright light, blinding you until you find yourself in another world.");
                        player.shiftLvl++;
                        Clear();
                        Exoplanet();

                        break;
                    }
                case "Pink":
                case "pink":
                    {
                        WriteLine("'Eh, good enough. Pink, I think, suits me second best after blue.' The fairy shrugs.\n'Well... I'll help you out anyways. The truth is, you've shifted into another reality. Don't sorry too much about the big details on what shifting is, you'll fry your brain on the way home. All you gotta know is, you have to get better at shifting to be able to navigate your way back home. Since you at least figured out what my second best color is, I'll give you a shifting point. Think of it like EXP or something. Anyways... best of luck to you and your decent fashion sense!'\nThe fairy flies away, bidding you farewell.");

                        WriteLine(" ");

                        WriteLine("You feel a surge of power, your mind seeming to clear like there had been a dense fog around. The sky beams a bright light, blinding you until you find yourself in another world.");
                        player.shiftLvl++;
                        Clear();
                        Exoplanet();

                        break;
                    }
            }
            ReadKey();
        }

        public void Exoplanet()
        {
            string choice;

            ForegroundColor = ConsoleColor.DarkMagenta;
            BackgroundColor = ConsoleColor.Blue;
            WriteLine("    ______                 __                 __ \n   / ____/  ______  ____  / /___ _____  ___  / /_\n  / __/ | |/_/ __ \\/ __ \\/ / __ `/ __ \\/ _ \\/ __/\n / /____>  </ /_/ / /_/ / / /_/ / / / /  __/ /_  \n/_____/_/|_|\\____/ .___/_/\\__,_/_/ /_/\\___/\\__/  \n                /_/                              ");
            ResetColor();


            WriteLine(" ");

            WriteLine("The light fades and you find yourself on Exoplanet, a world from a long forgotten indie game from your childhood. It's futuristic, technology detailing the city as if it were vegetation. Even the plants are fake.\nAs you walk around, taking in the scenery, you bump into a tall man, dressed in all black.\n'Make your choice', the man demands frantically, 'Do you want to stay in this simulation or do you want to be free?'.\nYou have no idea what the man means, but he pulls out three pills from his coat.");

            WriteLine("");

            WriteLine("The man leans in close to you, almost to the point where you can see his widened eyes from behind his shades. \n'Red will painfully free you, Blue will leave you in careless bliss. And purple... No one's actually chosen purple so...' The man's voice trails off and you stare at the pills.");

            Write("What color pill do you choose?: ");
            choice = ReadLine().ToLower();

            switch (choice)
            {
                case "Blue":
                case "blue":
                    {
                        WriteLine("The man frowns, 'Bad choice, kid...'\nYou swallow the blue pills and it's quite easy to swallow... almost as if you didn't swallow anything at all... almost as if... huh, aren't you late for work? \nHow'd you get here anyways?");

                        WriteLine(" ");

                        WriteLine("The world darkens as you pass out, never to be fully conscious again. You're stuck in this world... this simulation... forever...");

                        Clear();
                        YouLose();
                        break;
                    }
                case "Red":
                case "red":
                    {
                        WriteLine("You take the red pill. A difficult pill to swallow...");

                        WriteLine(" ");

                        WriteLine("The man smirks, 'You're either cultured, lucky, or wise. Either way, you'll make a great shifter yet. It's all about imagination and inspiration.'\nSuddenly, the man's tone darkens.\n'Not every question will be this easy... be wary of where you shift to. Other universes have different rules...'");

                        WriteLine(" ");

                        WriteLine("The man backs away before bidding you a kind farewell.\n'Stay safe, newbie. You feel another surge of power before you feel like you're choking on the red pill. The feeling doesn't last long; the next time you blink, you realize you're in another world...'");
                        player.shiftLvl++;
                        Clear();
                        NewUniverse();

                        break;
                    }
                case "Purple":
                case "purple":
                    {
                        WriteLine("'Wow... Purple, huh?' The man stares at you with concern as you take the purple pill. It's not hard to swallow, but not easy either...\n'Let me know how it go— Whoa!'");

                        WriteLine(" ");

                        WriteLine("The man's voice gets cut off as your body erupts into purple flames, blinding you and making it seem like your body's burning up. The flames aren't actually burning you...");
                        Clear();
                        NewUniverse();

                        break;
                    }
            }
            ReadKey();
        }

        public void NewUniverse()
        {
            string choice;

            ForegroundColor = ConsoleColor.DarkCyan;
            BackgroundColor = ConsoleColor.Magenta;
            WriteLine("    _   __                __  __      _                         \n   / | / /__ _      __   / / / /___  (_)   _____  _____________ \n  /  |/ / _ \\ | /| / /  / / / / __ \\/ / | / / _ \\/ ___/ ___/ _ \\\n / /|  /  __/ |/ |/ /  / /_/ / / / / /| |/ /  __/ /  (__  )  __/\n/_/ |_/\\___/|__/|__/   \\____/_/ /_/_/ |___/\\___/_/  /____/\\___/ \n                                                                ");
            ResetColor();

            WriteLine(" ");

            WriteLine("Once you realize you're alive, you open your eyes and find yourself in another universe. How do you know? The place is completely white with black specks... It doesn't even look like space with how the colors contrast.");

            WriteLine(" ");

            WriteLine("'You seem lost, mortal.' A calm, yet booming, voice erupts from the white matter and, before you know it, a gargantuan figure appears before you. Their entire body black, like a shadow, with only a white smile adorning their face.\n'Hmmm... You smell like you're far away from home... I can help you. But... You must answer my riddle.' Their smile widens, giving you an unsettling feeling.\n'Who makes it, has no need of it. Who buys it, has no use for it. Who uses it can neither see nor feel it. What is it?'");

            Write("Is it a Clock? A Coffin? Or a Child?");
            choice = ReadLine().ToLower();

            switch (choice)
            {
                case "Child":
                case "child":
                    {
                        WriteLine("'Tsk, Tsk...' The shadow frowns, 'You must have a deep dislike of children. Very cynical you are if you think the answer was a child...'\nThe figure seems to really dislike your answer, their frown only continues to grow.");

                        WriteLine(" ");

                        WriteLine("'Speaking of no use... Who says your universe would be better off with you in it? No... I think you got lost for a reason. The universe has spoken. You won't return home.' The figure murmurs before they reach for you, their giant hand expanding as it gets closer. \nIt envelops you, shouding you in darkness. It's like you're asleep, yet fully awake... It's almost like you're trapped in your body, unable to use it, but able to hear and feel...");
                        Clear();
                        YouLose();
                        break;
                    }
                case "Coffin":
                case "coffin":
                    {
                        WriteLine("The figure grins 'You're correct. A clever one aren't you? Hmm... With wisdom like that, I must send you back. Although... I really do wish I could keep you... Hm... Maybe, I can. Who knows' Their eerie smile grows, but they seem to like you.");

                        WriteLine(" ");

                        WriteLine("'Now, young one... It's time for you to be judgd by the universe. We'll see if you're allowed to go home or if you get to stay here with me. The figure watches with glee as the blue light of the universe shines for you. \n'Judgement awaits' you hear, unable to place or make out the voice.");

                        WriteLine(" ");

                        Clear();
                        player.shiftLvl++;
                        CheckLvl();

                        break;
                    }
                case "Clock":
                case "clock":
                    {
                        WriteLine("'Hmmm... Interesting answer. If you look at it differently, it could be right, but it's not the correct answer in this scenario... \nYou're practical, but not as imaginative as you should be for someone planning on multiversal travel...' The figure rambles on, not noticing the blue light shining down from the skies... \n'Judgement awaits...' You hear, unable to place or make out the voice.");

                        WriteLine(" ");

                        Clear();
                        CheckLvl();

                        break;
                    }
            }
            ReadKey();
        }

        public void CheckLvl()
        {
            if (player.shiftLvl == player.shifter)
            {
                Home();
            }
            else if (player.shiftLvl == 1)
            {
                YouLose();
            }
            else
            {
                NotEnough();
            }
        }

        public void Home()
        {
            WriteLine("You feel a final surge of power, your mind completely now that you're a high enough level to travel via shifting. You take a visit to each world you've been in before making your way home.\nYou sigh, laying in your bed while thinking about your journey.");

            WriteLine(" ");

            WriteLine("You lay in your bed a while, sleepily looking at the ceiling. You want to fall asleep, but you don't at the same time...\nEventually, you fall asleep due to the exhaustion. In the dream, you see faint flashes of a fairy, a man clad in black, and a figure with an eerie smile...");

            YouWin();
        }

        public void NotEnough()
        {
            WriteLine("The figure smiles.\n'You get to stay here with me. At least... only until the universe deems you fit for multiversal travel.'\nThe figure approaches you, their intimidating presence making you feel even more uneasy.\nWe'll have so much fun until you have to go home...");

            WriteLine("");

            WriteLine("You have no idea how long it'll take to raise your level enough to go back to your own universe... It could take more time than your human body can afford. You aren't lost, but aren't found either.\nYou're stuck.\nAt least the figure is nice... Right?");

            ReadKey();
            Clear();
            GameIntro();
        }

        public void YouWin()
        {
            WriteLine("You made it home!");
            WriteLine("Press 'Enter' to try a new path...");
            ReadLine();
            Clear();
            GameIntro();
        }

        public void YouLose()
        {
            WriteLine("You got lost forever...");
            WriteLine("Press 'Enter to try again...'");
            ReadLine();
            Clear();
            GameIntro();
        }
    }

}