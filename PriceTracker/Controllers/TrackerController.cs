using PriceTracker.Services;

namespace PriceTracker.Controllers;

class TrackerController
{
    private TrackerService _trackerService;
    public TrackerController(TrackerService trackerService)
    {
        _trackerService = trackerService;
    }
}
