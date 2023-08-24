using DependencyServiceApp.Helpers;
using DependencyServiceApp.UWP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceHelper))]
namespace DependencyServiceApp.UWP.Helpers
{
    public class DeviceHelper : IDeviceHelper
    {
        public string GetPlatformName()
        {
            return "UWP";
        }

        public Size GetScreenSize()
        {
            var width = Window.Current.Bounds.Width;
            var height = Window.Current.Bounds.Height;

            return new Size(width, height);
        }
    }
}
