using PriceTracker.Controllers;
using PriceTracker.Helpers;
using PriceTracker.Services;
using PriceTracker.Views;

namespace PriceTracker;

internal class Program
{
    internal static void Main()
    {
        TrackerService trackerService = new TrackerService();
        TrackerController trackerController = new TrackerController(trackerService);
        PromptProvider promptProvider = new PromptProvider();
        TrackerView trackerView = new TrackerView(trackerController, promptProvider);

        trackerView.Run();
    }
}
