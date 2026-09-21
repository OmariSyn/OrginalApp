using Microsoft.Maui.Controls;

namespace RSVPNavigation_APP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            // Simulated login credentials
            string correctUsername = "admin";
            string correctPassword = "password123";

            // Prompt user for credentials
            string username = await DisplayPromptAsync("Login", "Enter your username:");
            string password = await DisplayPromptAsync("Login", "Enter your password:", "OK", "Cancel", "", -1, Keyboard.Default);

            // Validate credentials
            if (username == correctUsername && password == correctPassword)
            {
                await DisplayAlert("Login Successful", "Welcome back!", "OK");
                // Navigate to the EventListPage after successful login
                await Navigation.PushAsync(new EventListPage());
            }
            else
            {
                await DisplayAlert("Login Failed", "Invalid username or password.", "OK");
            }
        }

        private async void OnAddUserClicked(object sender, EventArgs e)
        {
            // Navigate to the AddUserPage for adding a new user
            await Navigation.PushAsync(new AddUserPage());
        }
    }
}