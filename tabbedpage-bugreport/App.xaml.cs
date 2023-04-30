using Microsoft.AspNetCore.Components;

namespace tabbedpage_bugreport;

public partial class App : Application
{
	public App(NavigationManager _manager)
	{
		InitializeComponent();
		MainPage = new NavigationPage(new MainPage());
	}
}
