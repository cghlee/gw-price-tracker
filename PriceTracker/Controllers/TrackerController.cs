using PriceTracker.Controllers.Interfaces;
using PriceTracker.Services.Interfaces;

namespace PriceTracker.Controllers;

class TrackerController : ITrackerController
{
    private ITrackerService _trackerService;
    public TrackerController(ITrackerService trackerService)
    {
        _trackerService = trackerService;
    }
}
