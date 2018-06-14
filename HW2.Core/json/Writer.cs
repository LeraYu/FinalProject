using System.IO;

namespace TP.Core.json
{
    public abstract class Writer
    {
        protected static void WriteToFile(string fileName, string json)
        {
            var file = new FileStream(fileName, FileMode.Create);
            var writer = new StreamWriter(file);
            writer.Write(json);
            writer.Close();
        }
    }
}