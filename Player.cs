namespace Barrenmoor
{
    public class Player : NPC
    {
        public Player(string name, Position position) : base(name, position)
        {
        }

        public void MovePlayer(string dir)
        {
            switch (dir.ToUpper())
            {
                case "N":
                    pos.Y += 1;
                    break;
                case "S":
                    pos.Y -= 1;
                    break;
                case "W":
                    pos.X -= 1;
                    break;
                case "E":
                    pos.X += 1;
                    break;

            }
        }


    }
}