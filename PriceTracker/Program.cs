using PriceTracker.Controllers;
using PriceTracker.Services;
using PriceTracker.Views;

namespace PriceTracker;

internal class Program
{
    internal static void Main()
    {
        TrackerService trackerService = new TrackerService();
        TrackerController trackerController = new TrackerController(trackerService);
        TrackerView trackerView = new TrackerView(trackerController);

        trackerView.Run();
    }
}
