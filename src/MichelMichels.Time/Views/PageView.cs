using MichelMichels.Time.ViewModels;

namespace MichelMichels.Time.Views;

public abstract class PageView : ContentPage
{
    protected override async void OnAppearing()
    {
        await GetViewModel().OnAppearing();
        base.OnAppearing();
    }

    protected override async void OnDisappearing()
    {
        await GetViewModel().OnDisappearing();
        base.OnDisappearing();
    }

    protected PageViewModel GetViewModel()
    {
        return (PageViewModel)BindingContext;
    }
}