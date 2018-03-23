using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XTraining
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            Initialize(Color.Accent);
        }

        private bool initializing;

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (initializing)
                return;

            double red = this.redSlider.Value,
                green = this.greenSlider.Value,
                blue = this.blueSlider.Value;

            this.initializing = true;
            this.redEntry.Text = red.ToString("F0");
            this.greenEntry.Text = green.ToString("F0");
            this.blueEntry.Text = blue.ToString("F0");
            this.initializing = false;

            Color color = Color.FromRgb(red / 255, green / 255, blue / 255);
            this.colorBox.Color = color;
        }

        private void OnTextCompleted(object sender, EventArgs e)
        {
            if (initializing)
                return;

            if (!double.TryParse(this.redEntry.Text, out double red) ||
                !double.TryParse(this.greenEntry.Text, out double green) ||
                !double.TryParse(this.blueEntry.Text, out double blue))
                return;

            this.initializing = true;
            this.redSlider.Value = red;
            this.greenSlider.Value = green;
            this.blueSlider.Value = blue;
            this.initializing = false;

            Color color = Color.FromRgb(red / 255, green / 255, blue / 255);
            this.colorBox.Color = color;
        }

        private void Initialize(Color color)
        {
            this.initializing = true;
            this.redSlider.Value = color.R * 255;
            this.greenSlider.Value = color.G * 255;
            this.blueSlider.Value = color.B * 255;
            this.redEntry.Text = (color.R * 255).ToString("F0");
            this.greenEntry.Text = (color.G * 255).ToString("F0");
            this.blueEntry.Text = (color.B * 255).ToString("F0");
            this.initializing = false;

            this.colorBox.Color = color;
        }
    }
}
