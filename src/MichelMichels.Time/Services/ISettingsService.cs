namespace MichelMichels.Time.Services;

public interface ISettingsService
{
    string DateTimeFormat { get; set; }
    string FontFamily { get; set; }
    double FontSize { get; set; }
    double MinFontSize { get; set; }
    double MaxFontSize { get; set; }
}
