using PriceTracker.Controllers;
using PriceTracker.Helpers;
using PriceTracker.Repositories;
using PriceTracker.Services;
using PriceTracker.Views;

namespace PriceTracker;

internal class Program
{
    internal static void Main()
    {
        FileManager fileManager = new FileManager();
        TrackerModel trackerModel = new TrackerModel(fileManager);
        TrackerService trackerService = new TrackerService(trackerModel);
        TrackerController trackerController = new TrackerController(trackerService);
        PromptProvider promptProvider = new PromptProvider();
        TrackerView trackerView = new TrackerView(trackerController, promptProvider);

        trackerView.Run();
    }
}
