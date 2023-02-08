namespace PinPadApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CorrectPinPage), typeof(CorrectPinPage));
	}
}
