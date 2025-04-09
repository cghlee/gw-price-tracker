using PriceTracker.Controllers.Interfaces;
using PriceTracker.Views.Interfaces;

namespace PriceTracker.Views;

internal class TrackerView : ITrackerView
{
    private ITrackerController _trackerController;
    internal TrackerView(ITrackerController trackerController)
    {
        _trackerController = trackerController;
    }

    public void Run()
    {
        Console.WriteLine("Testing.");
    }
}
