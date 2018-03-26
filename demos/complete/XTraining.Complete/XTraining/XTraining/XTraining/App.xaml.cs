using Xamarin.Forms;

namespace XTraining
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            FreshMvvm.FreshIOC.Container.Register<Services.INorthwindService, Services.NorthwindService>();

            if (Device.Idiom == TargetIdiom.Phone)
            {
                MainPage = new FreshMvvm.FreshNavigationContainer(FreshMvvm.FreshPageModelResolver.ResolvePageModel<PageModels.MainPageModel>());
            }
            else
            {
                var masterDetail = new FreshMvvm.FreshMasterDetailNavigationContainer();
                masterDetail.Init("Menu");
                masterDetail.AddPage<PageModels.ChartPageModel>("Chart");
                masterDetail.AddPage<PageModels.DataGridPageModel>("DataGrid");
                masterDetail.AddPage<PageModels.ListPageModel>("List");
                MainPage = masterDetail;
            }
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
