using System.IO;

namespace TP.Core.json
{
    public abstract class Reader
    {
        protected static string ReadFromFile(string fileName)
        {
            var reader = new StreamReader(fileName);
            var json = reader.ReadLine();
            return json;
        }
    }
}