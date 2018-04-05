using System;

namespace Barrenmoor
{
    public class FlavourText
    {

        public static void IntroText()
        {
            var Intro = "Intro Text";

            Console.WriteLine(Intro + "\n");
        }

        public static void WelcomeText()
        {
            var Welcome = "What is your name adventurer";

            Console.WriteLine(Welcome);
        }


        public static void QuestText(Player player)
        {
            throw new NotImplementedException();
        }
    }
}