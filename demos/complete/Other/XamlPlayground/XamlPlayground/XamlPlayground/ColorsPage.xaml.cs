using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamlPlayground
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorsPage : ContentPage
    {
        public ColorsPage()
        {
            InitializeComponent();

            foreach (var item in ColorGenerator.GetColors())
            {
                var child = CreateColorFrame(item.Item1, item.Item2);
                this.stack.Children.Add(child);
            }
        }

        private static Frame CreateColorFrame(string name, Color color)
        {
            return new Frame()
            {
                OutlineColor = Color.Accent,
                Padding = new Thickness(5),
                Content = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15,
                    Children =
                    {
                        new BoxView() { Color = color},
                        new Label()
                        {
                            Text = name,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            FontAttributes = FontAttributes.Bold,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.StartAndExpand
                        },
                        new StackLayout()
                        {
                            Children =
                            {
                                new Label()
                                {
                                    Text = string.Format("{0:X2}-{1:X2}-{2:X2}", Convert.ToInt32(color.R * 255), Convert.ToInt32(color.G * 255), Convert.ToInt32(color.B * 255)),
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                },
                                new Label()
                                {
                                    Text = string.Format("{0:F2}-{1:F2}-{2:F2}", color.Hue, color.Saturation, color.Luminosity),
                                    VerticalOptions = LayoutOptions.CenterAndExpand,
                                    IsVisible = color != Color.Default
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}