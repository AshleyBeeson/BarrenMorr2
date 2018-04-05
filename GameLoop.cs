using System;

namespace Barrenmoor
{
    public class GameLoop
    {

        public void Loop()
        {
            
            FlavourText.IntroText();
            Player player = new Player(GetPlayerName(), new Position(0,0));
            FlavourText.QuestText(player);
            
            
            
        }

        private string GetPlayerName()
        {
            FlavourText.WelcomeText();
            return Console.ReadLine();
        }
        
        
    }
}