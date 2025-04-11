using PriceTracker.Controllers.Interfaces;
using PriceTracker.Services.Interfaces;

namespace PriceTracker.Controllers;

internal class TrackerController : ITrackerController
{
    private ITrackerService _trackerService;
    internal TrackerController(ITrackerService trackerService)
    {
        _trackerService = trackerService;
    }

    public bool HasExistingData()
    {
        bool hasExistingData = _trackerService.HasExistingData();
        return hasExistingData;
    }
}
