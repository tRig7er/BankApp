namespace BankApp;

public partial class LoginsPage : ContentPage
{
	public LoginsPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new RegistrationPage());
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new WelcomesPage());
    }
}