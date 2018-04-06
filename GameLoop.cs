using System;

namespace Barrenmoor
{
    public class GameLoop
    {

        private EventHandler eventHandler = new EventHandler();

        public void Loop()
        {
            bool isPlaying = true;
            int maxSizeOfGrid = 10;
            int maxAmtOfEvents = 50;
            Grid grid = new Grid(maxSizeOfGrid, maxAmtOfEvents);
            FlavourText.IntroText();
            Player player = new Player(GetPlayerName(), new Position(0,0));
            FlavourText.QuestText(player);

            while (isPlaying)
            {
                //Calculate any updates to the players stats
                player.CalcAttributes();

                //Display how far the player is from the goal
                Console.WriteLine("The Compasses main dial Says: " + Compass.Dist + "m");
                Console.WriteLine("The Compasses second dial Says: " + Compass.NearestEvent + "m");

                //Allow the player to make a choice of what they want to do
                player.Options();

                //Check if Event Exists at the players position
                Point Event = grid.CheckPlayerPos(player.pos);

                //Run the Event if Exists
                eventHandler.Handle(Event,player);

                //Display Player pos
                Console.WriteLine(string.Format("Current Pos: {0},{1}", player.pos.X, player.pos.Y));

                
                //Check for game to be completed
                if (player.hasCrown)
                {
                    isPlaying = false;
                }
            }
            //End game flavour text
            FlavourText.EndGameText(player);
            Console.Read();
        }

       
        private string GetPlayerName()
        {
            FlavourText.WelcomeText();
            return Console.ReadLine();
        }
        
        
        
    }
}