namespace Tron.Logic.GameLogic
{
    public class Player : IPlayer
    {

        public string Name { get; set; }
        public char Mark { get; set; }

        public int XCoordinate { get; set; }

        public int YCoordinate { get; set; }


        public Player(int xCoordinate, int yCoordinate, string name, char mark)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Name = name;
        }

    }
}
