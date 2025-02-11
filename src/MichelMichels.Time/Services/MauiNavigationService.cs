using MichelMichels.Time.Core.Services;

namespace MichelMichels.Time.Services;

public class MauiNavigationService : INavigationService
{
    public Task Initialize()
    {
        return NavigateTo("//Main");
    }

    public Task NavigateTo(string route, IDictionary<string, object>? parameters = null)
    {
        return
            parameters is not null
            ? Shell.Current.GoToAsync(route, parameters)
            : Shell.Current.GoToAsync(route);
    }

    public Task Pop()
    {
        throw new NotImplementedException();
    }
}
