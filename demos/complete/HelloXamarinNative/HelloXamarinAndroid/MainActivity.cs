using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloXamarinAndroid
{
    [Activity(Label = "HelloXamarinAndroid", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button myButton;
        private Java.Util.Concurrent.Atomic.AtomicInteger counter;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            counter = new Java.Util.Concurrent.Atomic.AtomicInteger(0);

            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            myButton = FindViewById<Button>(Resource.Id.button);
            myButton.Click += OnMyButtonClick;
        }

        private void OnMyButtonClick(object sender, System.EventArgs e)
        {
            myButton.Text = $"{counter.IncrementAndGet()} Clicks";
        }
    }
}

