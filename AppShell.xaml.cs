using iOSTitle.Pages;

namespace iOSTitle;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await Navigation.PushModalAsync(new LoginPage());
    }
}