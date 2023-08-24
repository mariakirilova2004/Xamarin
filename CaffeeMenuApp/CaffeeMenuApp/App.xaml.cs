using CaffeeMenuApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CaffeeMenuApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MenuListPage());
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
