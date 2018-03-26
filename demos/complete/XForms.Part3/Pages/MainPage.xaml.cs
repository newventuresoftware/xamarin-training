using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        public static string ColorPage = "color";
        public static string DialerPage = "dialer";

        private async void MenuItemClick(object sender, EventArgs e)
        {
            Page nextPage = null;
            Button btn = sender as Button;
            if (btn.StyleId == ColorPage)
            {
                nextPage = new ColorPage();
            }
            else if (btn.StyleId == DialerPage)
            {
                nextPage = new DialPage();
            }

            if (nextPage != null)
            {
                await Navigation.PushAsync(nextPage);
            }
        }
    }
}