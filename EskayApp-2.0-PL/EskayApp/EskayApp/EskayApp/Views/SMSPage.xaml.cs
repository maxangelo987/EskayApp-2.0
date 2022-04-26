using Plugin.Messaging;
using System;
using EskayApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EskayApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SMSPage : ContentPage
    {
        public SMSPage()
        {
            InitializeComponent();
            var name = senderName;
            name.Placeholder = "Type your name...";
            name.PlaceholderColor = Color.WhiteSmoke;
            name.IsEnabled = true;
        }

        private bool nameMsgIsReady = false;
        private bool msgOnlyIsReady = false;
        private void SendSMS_OnClicked(object sender, EventArgs e)
        {
            var txtMsg = feedbackEntry.Text;
            var nameSwitch = styleSwitch;
            var name = senderName;

            if (!string.IsNullOrEmpty(txtMsg))
            {
                if (!nameSwitch.IsToggled)
                {
                    if (!string.IsNullOrEmpty(name.Text))
                    {
                        nameMsgIsReady = true;
                        OnAlertYesNoClicked(sender, e);
                    }
                    else
                    {
                        nameMsgIsReady = false;
                        name.Placeholder = "Type your name...";
                        name.PlaceholderColor = Color.DarkRed;
                        name.Focus();
                    }
                }
                else
                {
                    OnAlertYesNoClicked(sender, e);
                    msgOnlyIsReady = true;
                }
            }
            else
            {
                msgOnlyIsReady = false;
                feedbackEntry.Placeholder = "Tell us what you think...";
                feedbackEntry.PlaceholderColor = Color.DarkRed;
                feedbackEntry.Focus();
            }
        }

        private void SendSMS(string message, string number)
        {
            var smsMessanger = CrossMessaging.Current.SmsMessenger;

            if (smsMessanger.CanSendSms)
            {
                smsMessanger.SendSms(number, message);
            }
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            var name = senderName;
            var switchToggled = styleSwitch;
            if (switchToggled.IsToggled)
            {
                name.Text = string.Empty;
                name.Placeholder = "Anonymous";
                name.PlaceholderColor = Color.WhiteSmoke;
                name.IsEnabled = false;
            }
            else
            {
                name.Placeholder = "Type your name...";
                name.PlaceholderColor = Color.DarkRed;
                name.IsEnabled = true;
                name.Focus();
            }
        }
        string action = string.Empty;
        public static Editor txtMsg;
        public static Editor name;
        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("EskayApp: Send to?", "Cancel", null, "Smart", "Globe");

            if (action != null)
            {
                txtMsg = feedbackEntry;
                name = senderName;
                string message = string.Empty;
                nameMsgIsReady = true;
                string smart_number = "09190023677";
                string globe_number = "09175773677";
                if (nameMsgIsReady)
                    message = txtMsg.Text + "via_app" + name.Text;
                if (msgOnlyIsReady)
                    message = txtMsg.Text + "via_app";

                if (action.Equals("Globe"))
                {
                    //SendSMSv2(globe_number, message);
                    SendSMS(message, globe_number);
                }
                else if (action.Equals("Smart"))
                {
                    //SendSMSv2(smart_number, message);
                    SendSMS(message, smart_number);

                }
                name.Placeholder = "Type your name...";
                name.PlaceholderColor = Color.WhiteSmoke;
            }
        }

        private void SendSMSv2(string number,string message) {
            try
            {
                DependencyService.Get<ISMS>().Send(number, message);
                //DependencyService.Get<IMessage>().ShortTime("SMS Sent Successfully");
            }
            catch(Exception ex)
            {
                DependencyService.Get<IMessage>().ShortTime("SMS Failed to Send, Please try again");
            }
        }

        const int MSG_LENGTH = 400;
        private void FeedbackEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            int msg_counter = feedbackEntry.Text.Length;
            if(msg_counter > MSG_LENGTH)
            {
                string message = "Accepts 400 characters only.";
                DependencyService.Get<IMessage>().ShortTime(message);
                feedbackEntry.Text = feedbackEntry.Text.Substring(0, 400);
            }
        }
        const int NAME_LENGTH = 50;
        private void SenderName_TextChanged(object sender, TextChangedEventArgs e)
        {
            int name_counter = senderName.Text.Length;
            if (name_counter > NAME_LENGTH)
            {
                string message = "Accepts 50 characters only.";
                DependencyService.Get<IMessage>().ShortTime(message);
                senderName.Text = senderName.Text.Substring(0, 50);
            }
        }
    }
}
