using Tron.Logic.GameLogic;

namespace Tron.Logic.Movements
{
    public class Up : IMovement
    {
        public void Move()
        {
            
        }

        public string GetIdentifier()
        {
            return "arriba";
        }

        public string PlayerName { get; set; }
    }
}
