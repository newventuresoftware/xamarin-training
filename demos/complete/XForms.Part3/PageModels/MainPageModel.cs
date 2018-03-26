using System.Windows.Input;
using Xamarin.Forms;

namespace XForms.PageModels
{
    public class MainPageModel : FreshMvvm.FreshBasePageModel
    {
        public MainPageModel()
        {
            this.navigateCommand = new Command<string>(OnNavigate);
        }

        private Command<string> navigateCommand;

        public static string ColorPage = "color";
        public static string DialerPage = "dialer";

        public ICommand NavigateCommand => this.navigateCommand;

        public override void Init(object initData)
        {
            base.Init(initData);
        }

        private async void OnNavigate(string target)
        {
            if (target == ColorPage)
            {
                await CoreMethods.PushPageModel<ColorPageModel>(null, false, true);
            }
            else if (target == DialerPage)
            {
                await CoreMethods.PushPageModel<DialPageModel>(null, false, true);
            }
        }
    }
}
