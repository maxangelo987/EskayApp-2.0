using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using EskayApp.Droid;
using EskayApp.Interfaces;
using Xamarin.Forms;
using Android.Telephony;


[assembly: Dependency(typeof(SMS_Droid))]
namespace EskayApp.Droid  
{
    public class SMS_Droid : ISMS
    {
        public void Send(string number, string message)
        {

            //Intent smsIntent = new Intent(Intent.ActionView);
            //smsIntent.SetType("vnd.android-dir/mms-sms");
            //smsIntent.PutExtra("address", number);
            //smsIntent.PutExtra("sms_body", message);
            //smsIntent.AddFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
            //Android.App.Application.Context.StartActivity(smsIntent);
            //var piSent = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, new Intent("SMS_SENT"), 0);
            //var piDelivered = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, new Intent("SMS_DELIVERED"), 0);
            //SubscriptionManager subscriptionManager = SubscriptionManager.from(getApplicationContext());
            //List<SubscriptionInfo> subscriptionInfoList = subscriptionManager.getActiveSubscriptionInfoList();
            //for (SubscriptionInfo subscriptionInfo : subscriptionInfoList)
            //{
            //    int subscriptionId = subscriptionInfo.getSubscriptionId();
            //}
            //var piSent = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, new Intent("SMS_SENT"), 0);

            //BroadcastReceiver receiver;

            //SmsManager sms = SmsManager.Default;
            //sms.SendTextMessage(number, null, message, null, null);

            //var smsUri = Android.Net.Uri.Parse("smsto:" + number);
            //var smsIntent = new Intent(Intent.ActionView, smsUri);
            //smsIntent.PutExtra("sms_body", message);
            //smsIntent.AddFlags(ActivityFlags.NewTask);
            //PendingIntent pi = PendingIntent.GetActivity(Android.App.Application.Context, 0, smsIntent, 0);
            //Android.App.Application.Context.StartActivity(smsIntent);
            //if (Android.OS.Build.VERSION.SdkInt >= Android.OS.Build.VERSION_CODES.LollipopMr1)
            //{
            //int subscriptionId;
            //SubscriptionManager subscriptionManager1 = (SubscriptionManager)Forms.Context.GetSystemService(Context.TelephonySubscriptionService);
            ////<SubscriptionInfo> subsInfoList = subscriptionManager1.ActiveSubscriptionInfoList;
            //SubscriptionInfo subscriptionInfo = subscriptionManager1.GetActiveSubscriptionInfoForSimSlotIndex(0);
            //SmsManager.GetSmsManagerForSubscriptionId(subscriptionInfo.SubscriptionId).SendTextMessage(number, null, message, null, null);

            //foreach (SubscriptionInfo subscriptionInfo in subsInfoList)
            //{
            //    //string numbers = subscriptionInfo.Number;
            //    //Console.WriteLine("numbers====" + numbers);
            //     subscriptionId = subscriptionInfo.getSubscriptionId();
            //}

            //MainActivity.Send( number,  message);
            //}
            //var piSent = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, new Intent("SMS_SENT"), 0);
            //var piDelivered = PendingIntent.GetBroadcast(Android.App.Application.Context, 0, new Intent("SMS_DELIVERED"), 0);
            //MainActivity._smsManager.SendTextMessage(number, null, message, piSent, piDelivered);
        }


        public void Call(string number)
        {
            //var uri = Android.Net.Uri.Parse("tel:" + number);
            //Intent intent = new Intent(Intent.ActionCall, uri);
            //intent.AddFlags(ActivityFlags.NewTask);
            //Android.App.Application.Context.StartActivity(intent);
        }
    }
}