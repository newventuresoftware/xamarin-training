using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DialPage : ContentPage
	{
		public DialPage()
		{
			InitializeComponent();
		}

        private void OnNumberClick(object sender, EventArgs e)
        {
            Button pressedButton = sender as Button;
            string digit = pressedButton.Text;

            this.numberLabel.Text += digit;
        }

        private void OnBackspaceClick(object sender, EventArgs e)
        {
            string number = this.numberLabel.Text;

            if (string.IsNullOrEmpty(number))
                return;

            this.numberLabel.Text = number.Remove(number.Length - 1, 1);
        }

        private void OnCallClick(object sender, EventArgs e)
        {
            // TODO: Implement
        }
    }
}
