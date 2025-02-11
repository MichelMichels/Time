using MichelMichels.Time.ViewModels;

namespace MichelMichels.Time.Views;

public partial class SettingsPage : PageView
{
    public SettingsPage(SettingsViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}