using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTraining.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}

        private async void MenuItemClick(object sender, EventArgs e)
        {
            Page nextPage = null;
            Button btn = sender as Button;
            switch (btn.StyleId)
            {
                case "color":
                    nextPage = new MainPage();
                    break;
                case "dial":
                    nextPage = FreshMvvm.FreshPageModelResolver.ResolvePageModel<PageModels.DialPageModel>();
                    break;
            }

            if (nextPage != null)
            {
                await Navigation.PushAsync(nextPage);
            }
        }
    }
}