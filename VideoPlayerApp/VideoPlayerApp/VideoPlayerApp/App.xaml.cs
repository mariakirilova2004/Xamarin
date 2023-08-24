using System;
using VideoPlayerApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VideoPlayerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new VideoListPage());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
