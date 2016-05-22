namespace Tron.Logic.ParserService
{
    public interface IReader
    {
        void RewindToBeggining();
        string GetNextLine();
    }
}
