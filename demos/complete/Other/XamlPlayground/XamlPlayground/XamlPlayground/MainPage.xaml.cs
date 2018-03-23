using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlPlayground
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent();
		}

        private async void OnStackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackPage());
        }

        private async void OnGridButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
    }
}