using Tron.Logic.GameLogic;
namespace Tron.Logic.ParserService
{
    interface IParser
    {
        IMovement GetNextMovement();
    }
}
