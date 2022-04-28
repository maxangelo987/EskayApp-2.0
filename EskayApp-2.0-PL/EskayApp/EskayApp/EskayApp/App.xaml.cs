using System.Reflection;
using Prism.Autofac;
using Prism.Ioc;
using EskayApp.Helpers.Extentions;
using EskayApp.Views;
using RestSharp;
using System;

namespace EskayApp
{
    public partial class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            InitializeComponent();

            MainPage = new MainPage();
            //NavigationService.NavigateAsync("main");
        }
        protected override void OnStart()
        {
            String respond_wake_up = Wake_Up();
            // Handle when your app starts
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<HomePage>();
            containerRegistry.AutoRegisterMvvmComponents(typeof(App).GetTypeInfo().Assembly);
        }
        public static string Wake_Up()
        {
            try
            {
                RestClient restClient = new RestClient("https://eskayapp-2-api.herokuapp.com/");
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
