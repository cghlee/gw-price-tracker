using PriceTracker.Repositories.Interfaces;
using PriceTracker.Services.Interfaces;

namespace PriceTracker.Services;

internal class TrackerService : ITrackerService
{
    private ITrackerRepository _trackerRepository;
    internal TrackerService(ITrackerRepository trackerRepository)
    {
        _trackerRepository = trackerRepository;
    }
    
    public bool HasExistingData()
    {
        bool hasExistingData = _trackerRepository.HasExistingData();
        return hasExistingData;
    }
}
