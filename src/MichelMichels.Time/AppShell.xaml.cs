using MichelMichels.Time.Core.Services;

namespace MichelMichels.Time;

public partial class AppShell : Shell
{
    private readonly INavigationService navigationService;

    public AppShell(INavigationService navigationService)
    {
        this.navigationService = navigationService ?? throw new ArgumentNullException(nameof(navigationService));
        InitializeComponent();
    }
}
