using System;
using Xamarin.Essentials;

[assembly: Xamarin.Forms.Dependency(typeof(XForms.Droid.MyCustomPhoneDialer))]
namespace XForms.Droid
{
    public class MyCustomPhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            try
            {
                Xamarin.Essentials.PhoneDialer.Open(number);

                return true;
            }
            catch (ArgumentNullException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Number was null or white space. PLease verify number and try again. Exception: {ex}");
            }
            catch (FeatureNotSupportedException ex)
            {
                System.Diagnostics.Debug.WriteLine($"Phone Dialer is not supported on this device. Exception: {ex}");
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Exception: {ex}");
            }

            return false;
        }
    }
}