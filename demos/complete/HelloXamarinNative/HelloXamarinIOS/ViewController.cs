using System;

using UIKit;

namespace HelloXamarinIOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        private int count;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void ButtonClicked(UIKit.UIButton sender)
        {
            count++;
            this.myButton.SetTitle($"{count} Clicks", UIControlState.Normal);
        }
    }
}