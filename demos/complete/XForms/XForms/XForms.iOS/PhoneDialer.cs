using Foundation;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(XForms.iOS.PhoneDialer))]
namespace XForms.iOS
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            return UIApplication.SharedApplication.OpenUrl(
                new NSUrl("tel:" + number));
        }
    }
}