using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EskayApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutPage : ContentPage
	{
		public AboutPage ()
		{
			InitializeComponent ();
		}
        private void BtnCall_Clicked(object sender, EventArgs e)
        {
            Browser.OpenAsync("https://www.researchgate.net/profile/Max-Angelo-Perin/", BrowserLaunchMode.SystemPreferred);
        }
    }
}