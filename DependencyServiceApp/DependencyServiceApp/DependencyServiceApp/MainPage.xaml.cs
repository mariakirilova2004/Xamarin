using DependencyServiceApp.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DependencyServiceApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            IDeviceHelper deviceHelper = DependencyService.Get<IDeviceHelper>();
            string platformName = deviceHelper.GetPlatformName();
            Size size = deviceHelper.GetScreenSize();

            lblName.Text = platformName;
            lblSize.Text = size.ToString();
        }
    }
}
