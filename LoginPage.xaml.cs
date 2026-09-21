namespace RSVPNavigation_APP;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Hard-coded credentials for validation
        if (UsernameEntry.Text == "admin" && PasswordEntry.Text == "password")
        {
            await DisplayAlert("Success", "Logged in successfully!", "OK");
            await Navigation.PushAsync(new EventListPage());
        }
        else
        {
            await DisplayAlert("Error", "Invalid credentials.", "OK");
        }
    }

    private async void OnGuestLoginClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Success", "Logged in as Guest!", "OK");
        await Navigation.PushAsync(new EventListPage());
    }
}