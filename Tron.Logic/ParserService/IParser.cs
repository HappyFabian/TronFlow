using Tron.Logic.GameLogic;
namespace Tron.Logic.ParserService
{
    public interface IParser
    {
        IMovement GetNextMovement();
    }
}
