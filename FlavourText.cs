using System;

namespace Barrenmoor
{
    public class FlavourText
    {

        public static void IntroText()
        {
            var Intro = "In the land of Flibbermoor, an ancient evil stirs.\n" +
                "As the land falls slowly into darkness the one thing holding it back is the 'Crown of Light', worn proudly by the ruler of the kingdom of Gallar.\n" +
                "As the darkness grew, foul creatures began to brave the day and started tormenting the citizens of Gallar.\n" +
                "The king and his army marched out to fight these creatures, defeating them in battle after battle.\n" +
                "After years of violent battles finally the king mounted one last attack into the heart of the darkness.\n" +
                "That was a year ago.The king and the crown are now lost.\n" +
                "The land is growing darker and with nothing to hold it back will soon overthrow the light.\n" +
                "A hero is need to find the crown and restore the light to the land...";

            Console.WriteLine(Intro + "\n");
        }

        public static void WelcomeText()
        {
            var Welcome = "Welcome, what is your name adventurer?";

            Console.WriteLine(Welcome);
        }

        public static void EndGameText(Player player)
        {
            var EndGame = "You beat the big bad and saved the world\nGo you!";
            Console.WriteLine(EndGame);
        }

        public static void QuestText(Player player)
        {
            var Quest = string.Format("{0}, your adventure awaits, find the missing Crown and save the world!\n" +
                "Using your trusty compass to guide your journey, the main dial seems to be locked on a fixed point\n" +
                "The second dial seems to be towards a point of interest", player.Name);
            Console.WriteLine(Quest);
        }

        public static void MovementText()
        {   
            var Move = "Choose the direction you wish to move:\n" + "(N)orth\n(E)ast\n(S)outh\n(W)est";
            Console.WriteLine(Move);
        }

        internal static void NothingFoundText()
        {
            var Nothing = "There doesn't seem to be anything of interest";
            Console.WriteLine(Nothing);
        }
    }
}