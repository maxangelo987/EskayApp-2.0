using Android.App;
using Android.Widget;
using EskayApp.Interfaces;
using Xamarin.Forms;
using EskayApp.Droid;
using Android.Views;

[assembly:Dependency(typeof(Message_Droid))]
namespace EskayApp.Droid
{
    public class Message_Droid : IMessage
    {
        public void LongTime(string message)
        {
            Toast toast = Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }

        public void ShortTime(string message)
        {
            Toast toast = Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short);
            toast.SetGravity(GravityFlags.Center, 0, 0);
            toast.Show();
        }
    }
}