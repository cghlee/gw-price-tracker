using PriceTracker.Models.Interfaces;
using PriceTracker.Services.Interfaces;

namespace PriceTracker.Services;

internal class TrackerService : ITrackerService
{
    private ITrackerModel _trackerModel;
    internal TrackerService(ITrackerModel trackerModel)
    {
        _trackerModel = trackerModel;
    }
}
