using MichelMichels.Time.ViewModels;

namespace MichelMichels.Time.Views;

public partial class MainPage : PageView
{
    public MainPage(MainViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }
}
