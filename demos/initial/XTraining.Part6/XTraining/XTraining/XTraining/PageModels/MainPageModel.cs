using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace XTraining.PageModels
{
    public class MainPageModel : FreshMvvm.FreshBasePageModel
    {
        public MainPageModel()
        {
            this.navigateCommand = new Command<string>(OnNavigate);
        }

        private Command<string> navigateCommand;

        public ICommand NavigateCommand => this.navigateCommand;

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        private async void OnNavigate(string target)
        {
            if (target == "color")
            {
                await CoreMethods.PushPageModel<ColorPageModel>(null, false, true);
            }
            else if (target == "dialer")
            {
                await CoreMethods.PushPageModel<DialPageModel>(null, false, true);
            }
            else if (target == "chart")
            {
                await CoreMethods.PushPageModel<ChartPageModel>(null, false, true);
            }
        }
    }
}
