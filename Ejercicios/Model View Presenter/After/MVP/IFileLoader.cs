namespace MVP
{
    using System.IO;

    public interface IFileLoader
    {
        Stream Load(string fileName);
    }
}