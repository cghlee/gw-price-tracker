using PriceTracker.Controllers.Interfaces;
using PriceTracker.Helpers.Interfaces;
using PriceTracker.Views.Interfaces;

namespace PriceTracker.Views;

internal class TrackerView : ITrackerView
{
    private ITrackerController _trackerController;
    private IPromptProvider _promptProvider;
    internal TrackerView(ITrackerController trackerController, IPromptProvider promptProvider)
    {
        _trackerController = trackerController;
        _promptProvider = promptProvider;
    }

    public void Run()
    {
        Console.WriteLine("Testing.");
    }
}