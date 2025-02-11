using CommunityToolkit.Mvvm.ComponentModel;
using MichelMichels.Time.Services;

namespace MichelMichels.Time.ViewModels;

public partial class SettingsViewModel(ISettingsService settingsService) : PageViewModel
{
    private readonly ISettingsService settingsService = settingsService ?? throw new ArgumentNullException(nameof(settingsService));

    [ObservableProperty]
    private int _fontSize;

    [ObservableProperty]
    private int _minFontSize;

    [ObservableProperty]
    private int _maxFontSize;

    [ObservableProperty]
    private string _dateTimeFormat = string.Empty;

    [ObservableProperty]
    private string _fontFamily = "OpenSansRegular";

    [ObservableProperty]
    private List<string> _fontFamilies = ["OpenSansRegular", "Consolas", "Arial"];

    public override Task OnAppearing()
    {
        MinFontSize = (int)settingsService.MinFontSize;
        MaxFontSize = (int)settingsService.MaxFontSize;
        FontSize = (int)settingsService.FontSize;
        DateTimeFormat = settingsService.DateTimeFormat;
        FontFamily = settingsService.FontFamily;

        return base.OnAppearing();
    }

    public override Task OnDisappearing()
    {
        settingsService.FontSize = FontSize;
        settingsService.DateTimeFormat = DateTimeFormat;
        settingsService.FontFamily = FontFamily;

        return base.OnDisappearing();
    }
}
