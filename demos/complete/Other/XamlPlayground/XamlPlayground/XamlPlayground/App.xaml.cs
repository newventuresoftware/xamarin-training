using Xamarin.Forms;

namespace XamlPlayground
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new NavigationPage(new XamlPlayground.MainPage());
            //MainPage = new ColorsPage();
            MainPage = new MyTabbedPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
