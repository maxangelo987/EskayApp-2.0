using DefaultNamespace;
using System;
using System.Collections.ObjectModel;
using EskayApp.Helpers;
using EskayApp.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using Plugin.Media.Abstractions;
using RestSharp;
using System.Threading.Tasks;
using System.Threading;

namespace EskayApp.Views
{
    [Page("home")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        private string myStringProperty;
        public string MyStringProperty
        {
            get { return myStringProperty; }
            set
            {
                myStringProperty = value;
                OnPropertyChanged(nameof(MyStringProperty)); // Notify that there was a change on this property
            }
        }

        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
            NavigationPage.SetHasNavigationBar(this, true);
            this.Title = "EskayApp | ᜁᜐ᜔ᜃᜌᜉ᜔ v.1";

        }

        string filePAth = string.Empty;
        private async void BtnCam_Clicked(object sender, EventArgs e)
        {
            try
            {
                String respond_wake_up = Wake_Up();
                Task.Factory.StartNew(() => {
                    MyStringProperty = "_";
                });


                var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions()
                {
                    DefaultCamera = CameraDevice.Rear,
                    Directory = "Xamarin",
                    CompressionQuality = 50,
                    PhotoSize = PhotoSize.Small,
                    MaxWidthHeight = 50,
                    SaveToAlbum = true
                });

                if (photo != null)
                {
                    imgCam.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
                    filePAth = photo.Path;
                }


            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
        private async void BtnTrans_Clicked(object sender, EventArgs e)
        {
            try
            {
                String respond = string.Empty;
                String final_respond = string.Empty;

                respond = Upload_Photo(filePAth);
                respond = respond.Replace("\"", "");



                switch (respond)
                {
                    case "A":
                        final_respond = "A (A)";
                        break;
                    case "B":
                        final_respond = "Bi (B)";
                        break;
                    case "C":
                        final_respond = "Si (C)";
                        break;
                    case "D":
                        final_respond = "Di (D)";
                        break;
                    case "E":
                        final_respond = "E (E)";
                        break;
                    case "F":
                        final_respond = "Ifhi (F)";
                        break;
                    case "G":
                        final_respond = "Gi (G)";
                        break;
                    case "H":
                        final_respond = "Atchi (H)";
                        break;
                    case "I":
                        final_respond = "I (I)";
                        break;
                    case "J":
                        final_respond = "Hu (J)";
                        break;
                    case "K":
                        final_respond = "Ka (K)";
                        break;
                    case "L":
                        final_respond = "Le (L)";
                        break;
                    case "M":
                        final_respond = "Mi (M)";
                        break;
                    case "N":
                        final_respond = "Ni (N)";
                        break;
                    case "O":
                        final_respond = "O (O)";
                        break;
                    case "P":
                        final_respond = "Pi (P)";
                        break;
                    case "Q":
                        final_respond = "Ku (Q)";
                        break;
                    case "R":
                        final_respond = "Ri (R)";
                        break;
                    case "S":
                        final_respond = "Si (S)";
                        break;
                    case "T":
                        final_respond = "Ti (T)";
                        break;
                    case "U":
                        final_respond = "U (U)";
                        break;
                    case "V":
                        final_respond = "Vi (V)";
                        break;
                    case "X":
                        final_respond = "Kis (X)";
                        break;
                    case "Y":
                        final_respond = "Yi (Y)";
                        break;
                };

                Task.Factory.StartNew(() => {
                    MyStringProperty = final_respond;
                });
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
        private void BtnSave_Clicked(object sender, EventArgs e)
        {

        }

        public static string Upload_Photo(string filepath)
        {
            try
            {
                RestClient restClient = new RestClient("https://eskayapp-api.herokuapp.com/");
                RestRequest restRequest = new RestRequest("/check_image/");
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.Method = Method.POST;
                restRequest.AddHeader("Content-Type", "multipart/form-data");
                restRequest.AddFile("eskaya_photo", filepath);
                var response = restClient.Execute(restRequest);
                return response.Content;
            }
            catch
            {
                return "Error";
            }
        }

        public static string Wake_Up()
        {
            try
            {
                RestClient restClient = new RestClient("https://eskayapp-api.herokuapp.com/");
                RestRequest restRequest = new RestRequest("/wake_up/");
                restRequest.RequestFormat = DataFormat.Json;
                restRequest.Method = Method.POST;
                var response = restClient.Execute(restRequest);
                return response.Content;
            }
            catch
            {
                return "Error";
            }
        }
    }
}