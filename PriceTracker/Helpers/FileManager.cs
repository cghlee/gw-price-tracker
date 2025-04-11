using PriceTracker.Helpers.Interfaces;

namespace PriceTracker.Helpers;

internal class FileManager : IFileManager
{
    public bool HasExistingData()
    {
        string dataFilePath = GetDataFilePath();
        bool dataFileExists = File.Exists(dataFilePath);
        return dataFileExists;
    }

    private string GetDataFilePath()
    {
        string exeBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string dataFilePath = Path.Combine(exeBaseDirectory, "data.json");
        return dataFilePath;
    }
}
