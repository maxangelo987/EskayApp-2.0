using Android;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Telephony;
using Android.Views;
using Android.Widget;
using CarouselView.FormsPlugin.Android;
using System;
using EskayApp.Views;

namespace EskayApp.Droid
{
    [Activity(Label = "EskayApp", Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
     
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            RequestPermissions(new string[] { Manifest.Permission.Camera, Manifest.Permission.WriteExternalStorage, Manifest.Permission.ReadExternalStorage }, 0);
            LoadApplication(new App());
           
        }
        public  bool hasPermissions(Context context,String[] permissions)
        {
            if (context != null && permissions != null)
            {
                foreach (String permission in permissions)
                {
                    if (ActivityCompat.CheckSelfPermission(context, permission) != Android.Content.PM.Permission.Granted)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
       

    }
}