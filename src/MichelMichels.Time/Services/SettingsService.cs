namespace MichelMichels.Time.Services;

public class SettingsService : ISettingsService
{
    public string DateTimeFormat { get; set; } = "HH:mm:ss";
    public double MinFontSize { get; set; } = 8;
    public double FontSize { get; set; } = 64;
    public double MaxFontSize { get; set; } = 512;
    public string FontFamily { get; set; } = "OpenSansRegular";

}
