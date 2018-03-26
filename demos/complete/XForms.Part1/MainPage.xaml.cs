using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
