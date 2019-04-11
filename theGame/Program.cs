using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theGame
{
    class Program
    {

        static void Main(string[] args)
        {

            breif();

            title();

            playerName();

            introduction();


            string introUsrInput = Console.ReadLine();
            string message = "";
            if (introUsrInput == "1")
            {
                chapterOne();
            }

            else if (introUsrInput == "2")
            {
                message = ("The stasis pod begins to fill with foul smelling gas, you eye lids become heavy and you drop off into a deep sleep. \nNever to wake again. \n\nGame Over. \n");
                Console.Write(message);
                Console.Write("Hit Enter to Exit");
            }
            Console .ReadLine();
        }

        static void breif()
        {
            string Brief = "---------------------------------------- \n" +
                 "This is a simple text adventure game, in the same vain as the \n" +
                 "choose your own adventure books. The main aim of this program \n" +
                 "is to teach myself C#. \n" +
                 "Elite Dangerous is a creation of Frontier Games and all rights belong to them, this is a fan made open source not for profit project. \n" +
                 "--------------------------------------- \n \n";
            Console.Write(Brief);
        }

        public static void introduction()
        {
            System.Media.SoundPlayer beepSound = new System.Media.SoundPlayer(@"H:\Documents\GitHub\Lost_in_Elite\audio\beep_22.wav");
            beepSound.PlayLooping();
            Console.Clear();
            System.Threading.Thread.Sleep(150);
            string Intro = "Your eyes slowly open accompanied with distance noise of computers. You feel fuzzy, you head is still spinning and you’re struggling to comprehend what you can see in front of you.\nSlowly the world comes to a stand stil." +
                "You find yourself in a stasis pod, with no recollection of how you got into this situation.\nThe last thing you remember clearly is celebrating at the local bar. What to do now? \n \n";
            for (int i = 0; i < Intro.Length; i++)
            {
                Console.Write(Intro[i]);
                System.Threading.Thread.Sleep(30);
            }
            string introOption1 = "1.	Force main hatch on stasis pod and get out. \n";
            string introOption2 = "2.	Wait to see if you can work out how you got here. \n";
            Console.WriteLine(introOption1);
            Console.WriteLine(introOption2);

            beepSound.Stop();
        }

        public static void chapterOne()
        {
            Console.Clear();
            string oneText = "\nAfter several attempts at breaking the seal to the stasis pod, it finally gives way and you tumble on to the cold metal deck.\n" +
                "The first thing you notice is the cold, where ever you are it's not had any human presence in while and the well worn overalls you have on are not much protection.\n" +
                "After a while your eyes become acustomed to the light, the dark shapes now come into focus. More stasis pods.\n" +
                "Most were broken, some looked to be occupied.\n\n After what seems like hours searching for anything useful, you happen upon a door control consol.\n" +
                "The door slid open with a smooth action, a rush of warmer fresher air rushed into the room. But before you could exit this strange store room, your path is blocked by a stranger.\n\n";
            for (int i = 0; i < oneText.Length; i++)
            {
                Console.Write(oneText[i]);
                System.Threading.Thread.Sleep(30);
            }

            string twoText = "I see that you have been able to get out of your stasis pod. At least we haven't lost you all to the malfunction. \n" +
                "";
        }

        private static void title()
        {
            string title = " __            _      _        _____ _ _ _       \n" +
                           "|  |   ___ ___| |_   |_|___   |   __| |_| |_ ___  \n" +
                           "|  |__| . |_ -|  _|  | |   |  |   __| | |  _| -_| \n" +
                           "|_____|___|___|_|    |_|_|_|  |_____|_|_|_| |___| \n\n\n\n\n\n";

            Console.Write(title);
            Console.ReadLine();
        }

        private static void playerName()
        {
            string playerName = "Input your name commander: ";
            Console.WriteLine(playerName);
            string cmdr = Console.ReadLine();
        }



    }
}
