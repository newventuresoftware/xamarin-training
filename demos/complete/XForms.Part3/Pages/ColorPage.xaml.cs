using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XForms.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorPage : ContentPage
	{
		public ColorPage()
		{
			InitializeComponent();

            Initialize(Color.Accent);
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = this.redSlider.Value,
                green = this.greenSlider.Value,
                blue = this.blueSlider.Value;

            Color color = Color.FromRgb(red / 255, green / 255, blue / 255);
            this.colorBox.Color = color;
        }

        private void Initialize(Color color)
        {
            this.redSlider.Value = color.R * 255;
            this.greenSlider.Value = color.G * 255;
            this.blueSlider.Value = color.B * 255;

            this.colorBox.Color = color;
        }
    }
}
