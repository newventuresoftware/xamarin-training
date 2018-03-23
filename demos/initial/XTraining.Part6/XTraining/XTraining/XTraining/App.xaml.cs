using Xamarin.Forms;

namespace XTraining
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            FreshMvvm.FreshIOC.Container.Register<Services.INorthwindService, Services.NorthwindService>();

            MainPage = new FreshMvvm.FreshNavigationContainer(FreshMvvm.FreshPageModelResolver.ResolvePageModel<PageModels.MainPageModel>());
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
