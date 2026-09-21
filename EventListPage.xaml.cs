namespace RSVPNavigation_APP;

public partial class EventListPage : ContentPage
{
    public EventListPage()
    {
        InitializeComponent();
    }

    private async void OnViewAllEventsClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(page: new EventDetailsPage());
    }

    private async void OnViewMyEventsClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Info", "This will show events you're attending/hosting.", "OK");
    }

    private async void OnAddEventClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddEventPage());
    }
}

internal class AddEventPage : Page
{
}