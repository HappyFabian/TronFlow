using System.IO;

namespace Tron.Logic.ParserService
{
    public class FileReader : IReader
    {
        private readonly StreamReader _streamReader;

        public FileReader(StreamReader streamReader)
        {
            _streamReader = streamReader;
        }
        public void RewindToBeggining()
        {
            _streamReader.BaseStream.Seek(0, 0);
        }

        public string GetNextLine()
        {
            if (_streamReader.EndOfStream)
                return null;
            else
            {
                var line = _streamReader.ReadLine();
                return line;
            }
        }
    }
}
