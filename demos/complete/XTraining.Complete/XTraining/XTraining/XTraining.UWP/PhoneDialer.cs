using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Calls;
using Windows.UI.Popups;

[assembly: Xamarin.Forms.Dependency(typeof(XTraining.UWP.PhoneDialer))]
namespace XTraining.UWP
{
    public class PhoneDialer : IDialer
    {
        public bool Dial(string number)
        {
            DialNumber(number);
            return true;
        }

        async Task<bool> DialNumber(string number)
        {
            var phoneLine = await GetDefaultPhoneLineAsync();
            if (phoneLine != null)
            {
                phoneLine.Dial(number, number);
                return true;
            }
            else
            {
                var dialog = new MessageDialog("No line found to place the call");
                await dialog.ShowAsync();
                return false;
            }
        }

        async Task<PhoneLine> GetDefaultPhoneLineAsync()
        {
            var phoneCallStore = await PhoneCallManager.RequestStoreAsync();
            var lineId = await phoneCallStore.GetDefaultLineAsync();
            return await PhoneLine.FromIdAsync(lineId);
        }
    }
}