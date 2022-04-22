using BottomBar.XamarinForms;
using System.Threading.Tasks;
using EskayApp.Helpers;
using Xamarin.Forms;

namespace EskayApp.Views
{
    [Page("main")]
    public partial class MainPage : BottomBarPage
    {
		public MainPage ()
		{
			InitializeComponent ();
		}
        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("EskayApp", "Do you really want to exit?", "Yes", "No");
                if (result) await this.Navigation.PopAsync();
            });
            return true;
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    // Waiting some time
        //    await Task.Delay(2000);

        //    //// Start animation
        //    //await Task.WhenAll(
        //    //    SplashGrid.FadeTo(0, 2000),
        //    //    Logo.ScaleTo(10, 2000)
        //    //    );
        //}
    }
}