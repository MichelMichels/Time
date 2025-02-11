namespace MichelMichels.Time.Core.Services;

public interface INavigationService
{
    Task Initialize();
    Task NavigateTo(string route, IDictionary<string, object>? parameters = null);
    Task Pop();
}
