using PriceTracker.Helpers.Interfaces;
using PriceTracker.Repositories.Interfaces;

namespace PriceTracker.Repositories;

internal class TrackerRepository : ITrackerRepository
{
    private IFileManager _fileManager;
    internal TrackerRepository(IFileManager fileManager)
    {
        _fileManager = fileManager;
    }
    
    public bool HasExistingData()
    {
        bool hasExistingData = _fileManager.HasExistingData();
        return hasExistingData;
    }
}
