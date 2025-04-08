using PriceTracker.Controllers;
using PriceTracker.Services;
using PriceTracker.Views;

namespace PriceTracker;

class Program
{
    static void Main()
    {
        TrackerService trackerService = new TrackerService();
        TrackerController trackerController = new TrackerController(trackerService);
        TrackerView trackerView = new TrackerView(trackerController);

        trackerView.Run();
    }
}
