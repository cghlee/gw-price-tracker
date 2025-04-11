using PriceTracker.Helpers.Interfaces;
using PriceTracker.Models.Interfaces;

namespace PriceTracker.Models;

internal class TrackerModel : ITrackerModel
{
    private IFileManager _fileManager;
    internal TrackerModel(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }
    
    public bool HasExistingData()
    {
        bool hasExistingData = _fileManager.HasExistingData();
        return hasExistingData;
    }
}
