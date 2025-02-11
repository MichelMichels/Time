using CommunityToolkit.Mvvm.ComponentModel;
using MichelMichels.Time.Core.Services;
using MichelMichels.Time.Services;

namespace MichelMichels.Time.ViewModels;

public partial class MainViewModel(IDateTimeProvider dateTimeProvider, ISettingsService settingsService) : PageViewModel
{
    private readonly IDateTimeProvider dateTimeProvider = dateTimeProvider ?? throw new ArgumentNullException(nameof(dateTimeProvider));
    private readonly ISettingsService settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));

    private readonly System.Timers.Timer _timer = new(TimeSpan.FromMilliseconds(500));

    [ObservableProperty]
    private string _time = string.Empty;

    [ObservableProperty]
    private string _format = settingsService.DateTimeFormat;

    [ObservableProperty]
    private double _fontSize = settingsService.FontSize;

    [ObservableProperty]
    private string _fontFamily = settingsService.FontFamily;

    public override Task OnAppearing()
    {
        EnableTime();

        Format = settingsService.DateTimeFormat;
        FontSize = settingsService.FontSize;
        FontFamily = settingsService.FontFamily;

        return base.OnAppearing();
    }

    private void Timer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
    {
        Time = dateTimeProvider.Now().ToString(settingsService.DateTimeFormat);
    }

    public void EnableTime()
    {
        _timer.Elapsed += Timer_Elapsed;
        _timer.Start();
    }
    public void DisableTime()
    {
        _timer.Elapsed -= Timer_Elapsed;
        _timer.Stop();
    }
}
