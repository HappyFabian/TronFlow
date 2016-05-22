namespace Tron.Logic.Movements
{
    public interface IMovement
    {
        void Move();
        string GetIdentifier();
        string PlayerName { get; set; }
    }
}
