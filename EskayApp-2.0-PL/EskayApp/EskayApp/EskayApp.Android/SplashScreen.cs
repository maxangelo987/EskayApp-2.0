using Android.App;
using Android.OS;
using Android.Content.PM;

namespace EskayApp.Droid
{
    [Activity(Label = "EskayApp 2.0", Icon = "@drawable/icon_fff", MainLauncher = true, Theme = "@style/SplashTheme",  ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(typeof(MainActivity));
            Finish();

            // Disable activity slide-in animation
            OverridePendingTransition(0, 0);
        }
    }
}