using PriceTracker.Controllers.Interfaces;
using PriceTracker.Views.Interfaces;

namespace PriceTracker.Views;

class TrackerView : ITrackerView
{
    private ITrackerController _trackerController;
    public TrackerView(ITrackerController trackerController)
    {
        _trackerController = trackerController;
    }

    public void Run()
    {
        Console.WriteLine("Testing.");
    }
}
