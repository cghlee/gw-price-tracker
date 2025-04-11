using PriceTracker.Helpers.Interfaces;

namespace PriceTracker.Helpers;

internal class FileManager : IFileManager
{
    public bool HasExistingData()
    {
        string exeBaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string dataFilePath = Path.Combine(exeBaseDirectory, "data.json");
        
        bool dataFileExists = File.Exists(dataFilePath);
        return dataFileExists;
    }
}
