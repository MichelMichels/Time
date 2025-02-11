using CommunityToolkit.Mvvm.ComponentModel;

namespace MichelMichels.Time.ViewModels;

public abstract class PageViewModel : ObservableObject
{
    public virtual Task OnAppearing()
    {
        return Task.CompletedTask;
    }
    public virtual Task OnDisappearing()
    {
        return Task.CompletedTask;
    }
}
