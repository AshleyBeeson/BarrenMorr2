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
            var Welcome = "Welcome, what is your name adventurer?";

            Console.WriteLine(Welcome);
        }

        public static void EndGameText(Player player)
        {
            var EndGame = "Game Over";
            Console.WriteLine(EndGame);
        }

        public static void QuestText(Player player)
        {
            var Quest = string.Format("{0}, your adventure awaits, find the missing Crown and save the world!", player.Name);
            Console.WriteLine(Quest);
        }

        public static void MovementText()
        {   
            var Move = "Choose the direction you wish to move:\n" + "(N)orth\n(E)ast\n(S)outh\n(W)est";
            Console.WriteLine(Move);
        }

    }
}