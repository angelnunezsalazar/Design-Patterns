namespace MVP
{
    using System.IO;

    public class FileLoader : IFileLoader
    {
        public Stream Load(string fileName)
        {
            return new FileStream(fileName, FileMode.Open);
        }
    }
}