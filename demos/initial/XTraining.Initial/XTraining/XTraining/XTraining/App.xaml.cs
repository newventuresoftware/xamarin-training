using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace XTraining
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // Register service
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
