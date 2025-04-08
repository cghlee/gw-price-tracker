using PriceTracker.Controllers;

namespace PriceTracker.Views;

class TrackerView
{
    private TrackerController _trackerController;
    public TrackerView(TrackerController trackerController)
    {
        _trackerController = trackerController;
    }

    public void Run()
    {
        Console.WriteLine("Testing.");
    }
}
