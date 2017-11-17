using Android.App;
using Android.Content.PM;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;

namespace NotificacionesPush.Droid
{
    [Activity(Label = "NotificacionesPush", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Initialize Azure Mobile Apps
            CurrentPlatform.Init();
            // Initialize Xamarin Forms
            global::Xamarin.Forms.Forms.Init(this, bundle);
            // Load the main application
            LoadApplication(new App());
        }
    }
}

