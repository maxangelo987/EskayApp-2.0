using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Messaging;
using EskayApp.Interfaces;

namespace EskayApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotlinePage : ContentPage
    {
        public HotlinePage()
        {
            InitializeComponent();
        }

        private void BtnCall_Clicked(object sender, EventArgs e)
        {
            OnAlertYesNoClicked(sender, e);

        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            string smart_number = "09190023677";
            string globe_number = "09175773677";

            string action = await DisplayActionSheet("EskayApp: Call to?", "Cancel", null, "Smart", "Globe");
            var PhoneCallTask = CrossMessaging.Current.PhoneDialer;

            if (action != null)
            {
                if (PhoneCallTask.CanMakePhoneCall)

                    if (action.Equals("Globe") && PhoneCallTask.CanMakePhoneCall)
                    {
                        PhoneCallTask.MakePhoneCall(globe_number);
                        //DependencyService.Get<ISMS>().Call(globe_number);
                    }

                    else if (action.Equals("Smart") && PhoneCallTask.CanMakePhoneCall)
                    {
                        PhoneCallTask.MakePhoneCall(smart_number);
                        //DependencyService.Get<ISMS>().Call(smart_number);
                    }
            }
           
        }

    }
}
