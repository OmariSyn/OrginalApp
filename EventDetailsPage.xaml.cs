using RSVPNavigation_APP.Models;

namespace RSVPNavigation_APP;

public partial class EventDetailsPage : ContentPage
{
    public EventDetailsPage()
    {
        InitializeComponent(); // Correct usage of InitializeComponent
    }

    public EventDetailsPage(Event eventDetails)
    {
        InitializeComponent(); // Correct usage of InitializeComponent
        BindingContext = eventDetails;
    }

  
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}