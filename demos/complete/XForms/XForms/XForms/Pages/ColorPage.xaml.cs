using Xamarin.Forms;

namespace XForms.Pages
{
    public partial class ColorPage : ContentPage
	{
		public ColorPage()
		{
			InitializeComponent();
		}

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            double red = this.redSlider.Value;
            double blue = this.blueSlider.Value;
            double green = this.greenSlider.Value;

            Color color = Color.FromRgb(red / 255, green / 255, blue / 255);
            this.colorBox.Color = color;
        }
    }
}
