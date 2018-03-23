using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XTraining.PageModels
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
        
        private void OnCallExecuted(object obj)
        {
            var dialer = DependencyService.Get<IDialer>();
            if (!string.IsNullOrEmpty(_number) && dialer != null)
                dialer.Dial(_number);
        }

        private void OnBackspaceExecuted(object obj)
        {
            if (string.IsNullOrEmpty(_number))
                return;

            Number = _number.Remove(_number.Length - 1, 1);
        }
    }
}
