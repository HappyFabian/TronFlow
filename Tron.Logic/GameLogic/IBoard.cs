namespace Tron.Logic.GameLogic
{
    public interface IBoard
    {
        void InitializeMap(object value);

        void MarkSpot(int xCoordinate, int yCoordinate, object value);
    }
}
