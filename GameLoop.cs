using System;

namespace Barrenmoor
{
    public class GameLoop
    {

        public void Loop()
        {
            bool isPlaying = true;
            bool hasCrown = false;
            Grid grid = new Grid(30, 10);
            FlavourText.IntroText();
            Player player = new Player(GetPlayerName(), new Position(0,0));
            FlavourText.QuestText(player);

            while (isPlaying)
            {
                var move = GetMovement();

                if (hasCrown)
                {
                    isPlaying = false;
                }
            }
            FlavourText.EndGameText(player);
            Console.Read();
        }

        private string GetPlayerName()
        {
            FlavourText.WelcomeText();
            return Console.ReadLine();
        }
        
        private string GetMovement()
        {
            FlavourText.MovementText();
            return Console.ReadLine();
        }
        
    }
}