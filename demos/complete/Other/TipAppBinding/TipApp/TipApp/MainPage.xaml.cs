using System;
using Xamarin.Forms;

namespace TipApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.tipSlider.Value = 0.1;
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            decimal tipValue = Convert.ToDecimal(this.tipSlider.Value);
            if (decimal.TryParse(this.billBox.Text, out decimal bill))
            {
                decimal total = bill + (bill * tipValue);
                this.totalBox.Text = $"Total: {total:C}";
            }
        }
    }
}
