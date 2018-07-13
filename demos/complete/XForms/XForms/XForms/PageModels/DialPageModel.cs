using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XForms.PageModels
{
    public class DialPageModel : FreshMvvm.FreshBasePageModel
    {
        public DialPageModel()
        {
            _digitCommand = new Command<string>(OnDigitCommandExecuted);
            _backspaceCommand = new Command(OnBackspaceExecuted);
            _callCommand = new Command(OnCallExecuted);
            _number = string.Empty;
        }

        private Command<string> _digitCommand;
        private Command _callCommand, _backspaceCommand;
        private string _number;

        public ICommand DigitCommand => _digitCommand;
        public ICommand CallCommand => _callCommand;
        public ICommand BackspaceCommand => _backspaceCommand;

        public string Number
        {
            get => _number;
            set
            {
                if (_number == value)
                    return;

                _number = value;
                RaisePropertyChanged();
            }
        }

        private void OnDigitCommandExecuted(string digit)
        {
            this.Number = _number + digit;
        }

        private async void OnCallExecuted(object obj)
        {
            var dialer = DependencyService.Get<IDialer>();
            if (string.IsNullOrEmpty(_number) || dialer == null)
                return;

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Phone);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Phone))
                    {
                        await CoreMethods.DisplayAlert("Need permission", $"In order to call {_number} I need access to Phone.", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Phone);
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(Permission.Phone))
                        status = results[Permission.Phone];
                }

                if (status == PermissionStatus.Granted)
                {
                    dialer.Dial(_number);
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await CoreMethods.DisplayAlert("Phone Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error: " + ex);
            }
        }

        private void OnBackspaceExecuted(object obj)
        {
            if (string.IsNullOrEmpty(_number))
                return;

            Number = _number.Remove(_number.Length - 1, 1);
        }
    }
}
