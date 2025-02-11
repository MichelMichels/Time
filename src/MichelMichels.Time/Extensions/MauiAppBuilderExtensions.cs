using MichelMichels.Time.Core.Services;
using MichelMichels.Time.Services;

namespace MichelMichels.Time.Extensions;

public static class MauiAppBuilderExtensions
{
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<INavigationService, MauiNavigationService>();
        mauiAppBuilder.Services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
        mauiAppBuilder.Services.AddSingleton<ISettingsService, SettingsService>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<ViewModels.MainViewModel>();
        mauiAppBuilder.Services.AddSingleton<ViewModels.SettingsViewModel>();

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<AppShell>();
        mauiAppBuilder.Services.AddSingleton<Views.MainPage>();
        mauiAppBuilder.Services.AddSingleton<Views.SettingsPage>();

        return mauiAppBuilder;
    }
}
